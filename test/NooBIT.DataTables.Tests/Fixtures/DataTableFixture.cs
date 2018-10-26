using NooBIT.DataTables.Models;
using NooBIT.DataTables.Tests.Models;

namespace NooBIT.DataTables.Tests.Fixtures
{
    public class DataTableFixture
    {
        public DataTableFixture()
        {
            QueryableService = new TestEntityQueryableService();
            Table = new TestEntityTable(QueryableService);
            Request = new TestRequest();
        }

        public TestEntityQueryableService QueryableService { get; }

        public TestEntityTable Table { get; }

        public DataTableRequest Request { get; }
    }
}