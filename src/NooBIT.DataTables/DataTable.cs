using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
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
        private Column[] _columns;

        public DataTable(
            IQueryableRequestService<TEntity> queryableRequestService)
        {
            _queryableRequestService = queryableRequestService;
        }

        public virtual async Task<DataTableResponse> GetAsync(DataTableRequest request, CancellationToken token = default)
        {
            var result = new DataTableResponse
            {
                Draw = request.Draw
            };

            try
            {
                var query = _queryableRequestService.Get();
                query = await GlobalWhereAsync(query, token);

                result.RecordsTotal = await GetTotalRecordsCount(query, request, token);

                var expr = BuildWhereExpression(request);
                query = query.Where(expr);

                result.RecordsFiltered = await GetFilteredRecordsCount(query, request, token);

                var orderInstructions = GenerateSortInstructions(request);
                query = Sorter.SortBy(query, orderInstructions);

                if (request.Length >= 0)
                {
                    query = query.Skip(request.Start).Take(request.Length);
                }

                var data = await GetValues(query, token);
                foreach (var d in data)
                {
                    var dict = await MapResultSetAsync(d, token);
                    result.Data.Add(dict);
                }
            }
            catch (Exception exception)
            {
                // TODO localizable string
                result.Error = "\nEin unerwarteter Fehler ist aufgetreten.\nPrüfen Sie Ihre Eingaben und versuchen Sie es erneut.";
                await OnError(request, exception);
            }

            return result;
        }

        protected virtual Expression<Func<TEntity, bool>> BuildWhereExpression(DataTableRequest request)
        {
            var searchRequested = request.Columns.Any(column => IsSearchable(request.Search, column));
            var expression = searchRequested ? (x => false) : (Expression<Func<TEntity, bool>>)(x => true);

            foreach (var column in request.Columns)
            {
                if (IsSearchable(request.Search, column, out string searchValue))
                {
                    var property = typeof(TEntity).GetProperty(column.Name);

                    if (!ConvertTypeHelper.TryConvert(searchValue, property.PropertyType, out var typedValue))
                        continue;

                    var lambda = ExpressionHelper.BuildExpression<TEntity>(property, typedValue);
                    expression = expression.Or(lambda);
                }
            }
            return expression;
        }

        public event Func<object, DataTableErrorEventArgs, Task> Error;
        public virtual Dictionary<int, string> DefaultColumnOrder { get; } = new Dictionary<int, string> { { 0, SortDirections.Ascending } };
        public virtual int DefaultPageLength { get; } = 100;

        private IEnumerable<SortInstruction> GenerateSortInstructions(DataTableRequest request)
        {
            return request.Order
                .SelectMany(o => Columns
                    .Single(x => x.Target == o.Column && x.Orderable)
                    .Orders
                    .Select(x => new SortInstruction
                    {
                        Name = x.ColumnName,
                        Direction = o.Dir.ToLower() == "asc" ? SortDirection.Ascending : SortDirection.Descending
                    }));
        }

        protected virtual Column GetColumnTemplate(PropertyInfo x, int index) => new Column(this)
        {
            Header = new Header { DisplayName = x.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? x.Name },
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

        public Column[] Columns => _columns ?? (_columns = GetColumnsInternal());

        protected virtual Column[] GetColumnsInternal() => typeof(TEntity)
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Select(GetColumnTemplate)
                .ToArray();

        protected virtual Task<List<TEntity>> GetValues(IQueryable<TEntity> query, CancellationToken token) => Task.FromResult(query.ToList());

        protected virtual Task<int> GetTotalRecordsCount(IQueryable<TEntity> query, DataTableRequest request, CancellationToken token) => Task.FromResult(query.Count());

        protected virtual Task<int> GetFilteredRecordsCount(IQueryable<TEntity> query, DataTableRequest request, CancellationToken token) => Task.FromResult(query.Count());

        private async Task OnError(DataTableRequest request, Exception exception)
        {
            var handler = Error;
            if (handler == null)
            {
                return;
            }

            var invocationList = handler.GetInvocationList();
            var handlerTasks = new Task[invocationList.Length];

            for (var i = 0; i < invocationList.Length; i++)
            {
                handlerTasks[i] = ((Func<object, DataTableErrorEventArgs, Task>)invocationList[i])(this, CreateOnErrorEventArgs(request, exception));
            }

            await Task.WhenAll(handlerTasks);
        }

        protected virtual DataTableErrorEventArgs CreateOnErrorEventArgs(DataTableRequest request, Exception exception) => new DataTableErrorEventArgs(request, exception);

        protected bool IsSearchable<TValue>(DataTableRequest.SearchRequest search, DataTableRequest.ColumnRequest column, out TValue searchValue)
        {
            var isSearchable = IsSearchable(search, column);
            var searchText = GetSearchText(search, column);
            var success = ConvertTypeHelper.TryConvert(searchText, out searchValue);
            return isSearchable && success;
        }

        protected bool IsSearchable(DataTableRequest.SearchRequest search, DataTableRequest.ColumnRequest column)
        {
            var searchText = GetSearchText(search, column);
            var col = Columns.Single(x => x.Name == column.Name);
            return col.Searchable && !string.IsNullOrWhiteSpace(searchText);
        }

        protected string GetSearchText(DataTableRequest.SearchRequest search, DataTableRequest.ColumnRequest column)
        {
            // column search beats global search 
            return !string.IsNullOrWhiteSpace(column.Search.Value)
                ? column.Search.Value
                : search.Value;
        }

        protected virtual Task<Dictionary<string, object>> MapResultSetAsync(TEntity result, CancellationToken token)
        {
            var properties = result.GetType().GetProperties();
            var dict = Columns.ToDictionary(x => x.Name, x => x.Render(properties.FirstOrDefault(y => y.Name == x.Name)?.GetValue(result), result));
            return Task.FromResult(dict);
        }

        /// <summary>
        /// Pre-filtering of all records before any other processing or altering of the query happens.
        /// </summary>
        /// <param name="query">The current query</param>
        /// <param name="token">The <cref="CancellationToken">CancellationToken</cref></param>
        /// <returns></returns>
        protected virtual Task<IQueryable<TEntity>> GlobalWhereAsync(IQueryable<TEntity> query, CancellationToken token) => Task.FromResult(query);

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
            public Order[] Orders { get; set; } = { };
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
                Columns = table.Columns.OrderBy(x => x.Target).ToArray();
            }

            public IDataTable<TEntity> DataTable { get; }
            public Row[] Rows { get; internal set; }
            public Column[] Columns { get; internal set; }
            public long TotalRecords { get; internal set; }
            public long FilteredRecords { get; internal set; }
        }

        public sealed class Row
        {
            public Row(IDataTable<TEntity> table)
            {
                Table = table;
                Columns = Table.Columns.OrderBy(x => x.Target).Select(x => new ValueColumn { Column = x }).ToArray();
            }

            public IDataTable<TEntity> Table { get; }
            public ValueColumn[] Columns { get; }

            public ValueColumn this[int index]
            {
                get => Columns[index];
                set => Columns[index] = value;
            }

            public ValueColumn this[string column]
            {
                get => Columns.Single(x => x.Column.Name == column);
                set
                {
                    var index = Array.FindIndex(Columns, col => col.Column.Name == column);
                    this[index] = value;
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
        DataTable<TEntity>.Column[] Columns { get; }
    }

    public interface IDataTable
    {
        Task<DataTableResponse> GetAsync(DataTableRequest request, CancellationToken token);
        event Func<object, DataTableErrorEventArgs, Task> Error;
    }
}