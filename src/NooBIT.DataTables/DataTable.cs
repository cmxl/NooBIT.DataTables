using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using NooBIT.DataTables.Attributes;
using NooBIT.DataTables.Helpers;
using NooBIT.DataTables.Models;
using NooBIT.DataTables.Queries;

namespace NooBIT.DataTables
{
    public abstract class DataTable<T> : IDataTable<T> where T : class
    {
        private readonly IQueryableRequestService<T> _queryableRequestService;
        protected readonly ISorter<T> Sorter = new Sorter<T>();
        private Column[] _columns;

        public DataTable(
            IQueryableRequestService<T> queryableRequestService)
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
                query = await PreFilter(query, token);
                query = await TotalRecords(query, result, token);
                query = Filter(query, request);
                query = await FilteredRecords(query, result, token);
                query = Sort(query, request);
                query = Paging(query, request);
                result = await GetResultData(result, query, token);
            }
            catch (Exception exception)
            {
                // TODO localizable string
                result.Error = "\nEin unerwarteter Fehler ist aufgetreten.\nPrüfen Sie Ihre Eingaben und versuchen Sie es erneut.";
                await OnError(request, exception);
            }

            return result;
        }

        private async Task<IQueryable<T>> PreFilter(IQueryable<T> query, CancellationToken token) => await GlobalWhereAsync(query, token);
        private async Task<IQueryable<T>> TotalRecords(IQueryable<T> query, DataTableResponse result, CancellationToken token = default)
        {
            result.RecordsTotal = await GetTotalRecordsCount(query, token);
            return query;
        }
        private IQueryable<T> Filter(IQueryable<T> query, DataTableRequest request) => Where(query, request);
        private async Task<IQueryable<T>> FilteredRecords(IQueryable<T> query, DataTableResponse result, CancellationToken token = default)
        {
            result.RecordsFiltered = await GetFilteredRecordsCount(query, token);
            return query;
        }

        private IQueryable<T> Sort(IQueryable<T> query, DataTableRequest request)
        {
            var orderInstructions = GenerateSortInstructions(request);
            return Sorter.SortBy(query, orderInstructions);
        }

        private IQueryable<T> Paging(IQueryable<T> query, DataTableRequest request)
        {
            return request.Length >= 0
                ? query.Skip(request.Start).Take(request.Length)
                : query;
        }

        private async Task<DataTableResponse> GetResultData(DataTableResponse result, IQueryable<T> query, CancellationToken token = default)
        {
            var data = await GetValues(query, token);
            foreach (var d in data)
            {
                var dict = await MapResultSetAsync(d, token);
                result.Data.Add(dict);
            }
            return result;
        }

        protected virtual List<SearchInstruction<T>> BuildSearchInstructions(DataTableRequest request)
        {
            var instructions = new List<SearchInstruction<T>>();

            var columns = Columns;

            // reset values
            foreach (var column in columns)
            {
                column.SearchInstruction.UseCustomExpression(null);
                column.SearchInstruction.Value = null;
            }

            foreach (var column in request.Columns)
            {
                if (!IsSearchable(request.Search, column, out object value))
                    continue;

                var instruction = columns.Single(x => x.Name == column.Name).SearchInstruction;
                if (instruction == null)
                    continue;

                instruction.Value = value;
                instructions.Add(instruction);
            }

            return instructions;
        }

        private IQueryable<T> Where(IQueryable<T> query, DataTableRequest request)
        {
            var instructions = BuildSearchInstructions(request);
            return query.SearchBy(instructions);
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

        protected virtual Column[] GetColumnsInternal() =>
            typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .OrderBy(x => x.GetCustomAttribute<ColumnOrderAttribute>()?.Order ?? int.MaxValue)
                .Select(GetColumnTemplate)
                .ToArray();

        protected virtual Task<List<T>> GetValues(IQueryable<T> query, CancellationToken token = default) => Task.FromResult(query.ToList());

        protected virtual Task<int> GetTotalRecordsCount(IQueryable<T> query, CancellationToken token = default) => Task.FromResult(query.Count());

        protected virtual Task<int> GetFilteredRecordsCount(IQueryable<T> query, CancellationToken token = default) => Task.FromResult(query.Count());

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

        protected virtual Task<Dictionary<string, object>> MapResultSetAsync(T result, CancellationToken token = default)
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
        protected virtual Task<IQueryable<T>> GlobalWhereAsync(IQueryable<T> query, CancellationToken token = default) => Task.FromResult(query);

        public sealed class Column
        {
            public Column(IDataTable<T> table)
            {
                Table = table;
                SearchInstruction = new SearchInstruction<T> { NameFunc = () => Name };
            }

            public IDataTable<T> Table { get; }
            public string Name { get; set; }
            public int Target { get; set; }
            public bool Searchable { get; set; }
            public bool Orderable { get; set; }
            public bool Hidden { get; set; }
            public Order[] Orders { get; set; } = { };
            public Func<object, T, object> Render { get; set; } = (data, entity) => data;
            public Footer Footer { get; set; }
            public Header Header { get; set; } = new Header();
            public SearchInstruction<T> SearchInstruction { get; internal set; }

            public sealed class Order
            {
                public string ColumnName { get; set; }
            }
        }

        public sealed class Table
        {
            public Table(IDataTable<T> table)
            {
                DataTable = table;
                Columns = table.Columns.OrderBy(x => x.Target).ToArray();
            }

            public IDataTable<T> DataTable { get; }
            public Row[] Rows { get; internal set; }
            public Column[] Columns { get; internal set; }
            public long TotalRecords { get; internal set; }
            public long FilteredRecords { get; internal set; }
        }

        public sealed class Row
        {
            public Row(IDataTable<T> table)
            {
                Table = table;
                Columns = Table.Columns.OrderBy(x => x.Target).Select(x => new ValueColumn { Column = x }).ToArray();
            }

            public IDataTable<T> Table { get; }
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

    public interface IDataTable<T> : IDataTable where T : class
    {
        DataTable<T>.Column[] Columns { get; }
    }

    public interface IDataTable
    {
        Task<DataTableResponse> GetAsync(DataTableRequest request, CancellationToken token = default);
        event Func<object, DataTableErrorEventArgs, Task> Error;
    }
}