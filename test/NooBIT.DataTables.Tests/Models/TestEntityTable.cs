using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NooBIT.DataTables.Models;
using NooBIT.DataTables.Queries;

namespace NooBIT.DataTables.Tests.Models
{
    public class TestEntityTable : DataTable<TestEntity>
    {
        public TestEntityTable(IQueryableRequestService<TestEntity> queryableRequestService) : base(queryableRequestService)
        {
        }

        protected override Task<IQueryable<TestEntity>> WhereAsync(IQueryable<TestEntity> query, DataTableRequest request, DataTableRequest.ColumnRequest column, CancellationToken token = default)
        {
            return Task.FromResult(query);
        }
    }
}