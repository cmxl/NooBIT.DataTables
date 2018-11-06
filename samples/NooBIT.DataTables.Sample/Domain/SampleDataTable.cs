using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using NooBIT.DataTables.Models;
using NooBIT.DataTables.Queries;
using NooBIT.DataTables.Sample.Model;

namespace NooBIT.DataTables.Sample.Domain
{
    public class SampleDataTable : DataTable<SampleData>
    {
        public SampleDataTable(IQueryableRequestService<SampleData> queryableRequestService) : base(queryableRequestService)
        {
        }

        //protected override Task<IQueryable<SampleData>> WhereAsync(IQueryable<SampleData> query, DataTableRequest request, DataTableRequest.ColumnRequest column, CancellationToken token)
        //{
        //    switch (column.Name?.ToLowerInvariant())
        //    {
        //        case "name":
        //            if (IsSearchable(request.Search, column, out string name)) 
        //                return Task.FromResult(query.Where(x => x.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0));
        //            break;
        //        case "id":
        //            if (IsSearchable(request.Search, column, out int id)) 
        //                return Task.FromResult(query.Where(x => x.Id == id));
        //            break;
        //    }

        //    return Task.FromResult(query);
        //}

        protected override Column GetColumnTemplate(PropertyInfo x, int index)
        {
            var template = base.GetColumnTemplate(x, index);
            template.Header.Filter = null;
            return template;
        }
    }
}