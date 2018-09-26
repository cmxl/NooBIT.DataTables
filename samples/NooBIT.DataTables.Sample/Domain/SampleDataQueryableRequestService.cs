using System.Linq;
using NooBIT.DataTables.Queries;
using NooBIT.DataTables.Sample.Model;

namespace NooBIT.DataTables.Sample.Domain
{
    public class SampleDataQueryableRequestService : IQueryableRequestService<SampleData>
    {
        public IQueryable<SampleData> Get()
        {
            return SampleDataStore.SampleData.AsQueryable();
        }
    }
}