using NooBIT.DataTables.Models;
using NooBIT.DataTables.Tests.Models;

namespace NooBIT.DataTables.Tests.Fixtures
{
    public class DataTableFixture
    {
        public DataTableFixture()
        {
            DataSource = new TestEntityDataSource();
            Table = new TestEntityTable(DataSource);
            Request = new TestRequest();
        }

        public TestEntityDataSource DataSource { get; }

        public TestEntityTable Table { get; }

        public DataTableRequest Request { get; }
    }
}