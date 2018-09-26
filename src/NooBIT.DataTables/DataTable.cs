using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using NooBIT.DataTables.Helpers;
using NooBIT.DataTables.Models;
using NooBIT.DataTables.Queries;

namespace NooBIT.DataTables
{
    public abstract class DataTable<TEntity> : IDataTable<TEntity> where TEntity : class
    {
        private readonly IQueryableRequestService<TEntity> _queryableRequestService;
        protected readonly Sorter<TEntity> Sorter = new Sorter<TEntity>();

        public DataTable(
            IQueryableRequestService<TEntity> queryableRequestService)
        {
            _queryableRequestService = queryableRequestService;
        }

        public virtual async Task<AjaxDataViewModel> GetAsync(AjaxProcessingViewModel vm, CancellationToken token = default(CancellationToken))
        {
            var result = new AjaxDataViewModel
            {
                Draw = vm.Draw
            };

            try
            {
                var query = _queryableRequestService.Get();
                query = await GlobalWhereAsync(query, token);

                result.RecordsTotal = await GetTotalRecordsCount(query, vm, token);

                foreach (var column in vm.Columns)
                {
                    if (token.IsCancellationRequested)
                        break;

                    query = await WhereAsync(query, vm, column, token);
                }

                result.RecordsFiltered = await GetFilteredRecordsCount(query, vm, token);

                var orderInstructions = GenerateInstructions(vm);
                query = Sorter.SortBy(query, orderInstructions);

                if (!token.IsCancellationRequested && vm.Length >= 0)
                    query = query.Skip(vm.Start).Take(vm.Length);

                var data = await GetValues(query, token);
                foreach (var d in data)
                {
                    if (token.IsCancellationRequested)
                        break;

                    var dict = await MapResultSetAsync(d, token);
                    foreach (var m in dict)
                    {
                        if (token.IsCancellationRequested)
                            break;

                        result.Data.Add(m);
                    }
                }
            }
            catch (Exception exception)
            {
                result.Error = "\nEin unerwarteter Fehler ist aufgetreten.\nPrüfen Sie Ihre Eingaben und versuchen Sie es erneut.";
                await OnError(vm, exception);
            }

            return result;
        }

        public event Func<object, DataTableErrorEventArgs, Task> Error;
        public virtual Dictionary<int, string> DefaultColumnOrder { get; } = new Dictionary<int, string> { {0, SortDirections.Ascending} };
        public virtual int DefaultPageLength { get; } = 100;

        private IEnumerable<SortInstruction> GenerateInstructions(AjaxProcessingViewModel vm)
        {
            var instructions = new List<SortInstruction>();
            foreach (var o in vm.Order)
            {
                var col = GetColumns().FirstOrDefault(x => x.Target == o.Column && x.Orderable);
                if (col == null)
                    continue;

                instructions.AddRange(col.Orders.Select(x => new SortInstruction {Name = x.ColumnName, Direction = o.Dir.ToLower() == "asc" ? SortDirection.Ascending : SortDirection.Descending}));
            }
            return instructions;
        }

        protected virtual Column GetColumnTemplate(PropertyInfo x, int index)
        {
            return new Column(this)
            {
                Header = new Header {DisplayName = x.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? x.Name},
                Name = x.Name,
                Orderable = true,
                Orders = new[]
                {
                    new Column.Order
                    {
                        ColumnName = x.Name
                    }
                },
                Render = (o, item) => o,
                Searchable = true,
                Target = index
            };
        }

        public virtual List<Column> GetColumns()
        {
            return typeof(TEntity)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Select(GetColumnTemplate)
                .ToList();
        }

        protected virtual Task<List<TEntity>> GetValues(IQueryable<TEntity> query, CancellationToken token)
        {
            return Task.FromResult(query.ToList());
        }

        protected virtual Task<int> GetTotalRecordsCount(IQueryable<TEntity> query, AjaxProcessingViewModel vm, CancellationToken token)
        {
            return Task.FromResult(query.Count());
        }

        protected virtual Task<int> GetFilteredRecordsCount(IQueryable<TEntity> query, AjaxProcessingViewModel vm, CancellationToken token)
        {
            return Task.FromResult(query.Count());
        }

        private async Task OnError(AjaxProcessingViewModel vm, Exception exception)
        {
            var handler = Error;
            if (handler == null)
                return;

            var invocationList = handler.GetInvocationList();
            var handlerTasks = new Task[invocationList.Length];

            for (var i = 0; i < invocationList.Length; i++)
                handlerTasks[i] = ((Func<object, DataTableErrorEventArgs, Task>) invocationList[i])(this, CreateOnErrorEventArgs(vm, exception));

            await Task.WhenAll(handlerTasks);
        }

        protected virtual DataTableErrorEventArgs CreateOnErrorEventArgs(AjaxProcessingViewModel vm, Exception exception)
        {
            return new DataTableErrorEventArgs(vm, exception);
        }

        protected bool IsSearchable<TValue>(AjaxSearch search, AjaxColumn column, out TValue searchValue)
        {
            var isSearchable = IsSearchable(search, column);
            var searchText = GetSearchText(search, column);
            var success = ConvertTypeHelper.TryConvert(searchText, out searchValue);
            return isSearchable && success;
        }

        protected bool IsSearchable(AjaxSearch search, AjaxColumn column)
        {
            var searchText = GetSearchText(search, column);
            var col = GetColumns().FirstOrDefault(x => x.Name == column.Name);
            return col != null && col.Searchable && !string.IsNullOrWhiteSpace(searchText);
        }

        protected string GetSearchText(AjaxSearch search, AjaxColumn column)
        {
            var searchText = column.Search.Value;
            if (!string.IsNullOrWhiteSpace(search.Value))
                searchText = search.Value;

            return searchText;
        }

        protected virtual async Task<IEnumerable<Dictionary<string, object>>> MapResultSetAsync(TEntity result, CancellationToken token)
        {
            var properties = result.GetType().GetProperties();
            var dict = GetColumns().ToDictionary(x => x.Name, x => x.Render(properties.FirstOrDefault(y => y.Name == x.Name)?.GetValue(result), result));
            return await Task.WhenAll(Task.FromResult(dict));
        } 

        protected virtual Task<IQueryable<TEntity>> GlobalWhereAsync(IQueryable<TEntity> query, CancellationToken token)
        {
            return Task.FromResult(query);
        }

        protected abstract Task<IQueryable<TEntity>> WhereAsync(IQueryable<TEntity> query, AjaxProcessingViewModel vm, AjaxColumn column, CancellationToken token);

        public sealed class Column
        {
            public Column(IDataTable<TEntity> table)
            {
                Table = table;
            }

            public IDataTable<TEntity> Table { get; }
            public string Name { get; set; }
            public int Target { get; set; }
            public bool Searchable { get; set; }
            public bool Orderable { get; set; }
            public bool Hidden { get; set; }
            public Order[] Orders { get; set; } = {};
            public Func<object, TEntity, object> Render { get; set; } = (data, entity) => data;
            public Footer Footer { get; set; }
            public Header Header { get; set; } = new Header();

            public sealed class Order
            {
                public string ColumnName { get; set; }
            }
        }

        public sealed class Table
        {
            public Table(IDataTable<TEntity> table)
            {
                DataTable = table;
            }

            public IDataTable<TEntity> DataTable { get; }
            public Row[] Rows { get; internal set; }
            public long TotalRecords { get; internal set; }
            public long FilteredRecords { get; internal set; }
        }

        public sealed class Row
        {
            public Row(IDataTable<TEntity> table)
            {
                Table = table;
            }

            private List<ValueColumn> _columns;

            public IDataTable<TEntity> Table { get; }
            public List<ValueColumn> Columns
            {
                get { return _columns ?? (_columns = Table.GetColumns().OrderBy(x => x.Target).Select(x => new ValueColumn {Column = x}).ToList()); }
            }

            public ValueColumn this[int index]
            {
                get => Columns[index];
                set => Columns[index] = value;
            }

            public ValueColumn this[string column]
            {
                get { return Columns.Single(x => x.Column.Name == column); }
                set
                {
                    var col = Columns.Single(x => x.Column.Name == column);
                    var index = Columns.IndexOf(col);
                    Columns[index] = value;
                }
            }

            public class ValueColumn
            {
                public Column Column { get; set; }
                public object Value { get; set; }
            }
        }
    }

    public interface IDataTable<TEntity> : IDataTable where TEntity : class
    {
        List<DataTable<TEntity>.Column> GetColumns();
    }

    public interface IDataTable
    {
        Task<AjaxDataViewModel> GetAsync(AjaxProcessingViewModel vm, CancellationToken token);
        event Func<object, DataTableErrorEventArgs, Task> Error;
    }
}