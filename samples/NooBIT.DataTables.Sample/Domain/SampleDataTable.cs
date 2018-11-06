using NooBIT.DataTables.Queries;
using NooBIT.DataTables.Sample.Model;

namespace NooBIT.DataTables.Sample.Domain
{
    public class SampleDataTable : DataTable<SampleData>
    {
        public SampleDataTable(IQueryableRequestService<SampleData> queryableRequestService) : base(queryableRequestService)
        {
        }
    }
}