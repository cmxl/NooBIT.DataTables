using NooBIT.DataTables.Queries;

namespace NooBIT.DataTables.Tests.Models
{
    public class TestEntityTable : DataTable<TestEntity>
    {
        public TestEntityTable(IQueryableRequestService<TestEntity> queryableRequestService) : base(queryableRequestService)
        {
        }
    }
}