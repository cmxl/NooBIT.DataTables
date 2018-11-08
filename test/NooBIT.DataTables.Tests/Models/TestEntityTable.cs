using NooBIT.DataTables.Queries;

namespace NooBIT.DataTables.Tests.Models
{
    public class TestEntityTable : DataTable<TestEntity>
    {
        public TestEntityTable(IDataSource<TestEntity> queryableRequestService) : base(queryableRequestService)
        {
        }
    }
}