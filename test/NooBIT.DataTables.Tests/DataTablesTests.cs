using System.Linq;
using System.Threading;
using NooBIT.DataTables.Rendering;
using NooBIT.DataTables.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace NooBIT.DataTables.Tests
{
    public class DataTablesTests : IClassFixture<DataTableFixture>
    {
        public DataTablesTests(DataTableFixture fixture, ITestOutputHelper output)
        {
            _fixture = fixture;
            _output = output;
        }

        private readonly DataTableFixture _fixture;
        private readonly ITestOutputHelper _output;

        [Fact]
        public void Table_Rendering_Does_Not_Crash()
        {
            var result = _fixture.Table.GetAsync(_fixture.ViewModel, CancellationToken.None).Result;
            var renderer = new TableRenderer();
            var table = renderer.Render(_fixture.Table, result);
            var orderedEntities = _fixture.QueryableService.Get().OrderBy(x => x.Id).ToArray();

            Assert.True(table.Rows.Length == orderedEntities.Length);
            Assert.True(table.Rows[0].Columns.Count == table.DataTable.GetColumns().Count);

            for (var i = 0; i < orderedEntities.Length; i++)
            {
                Assert.True((int) table.Rows[i]["Id"].Value == orderedEntities[i].Id);
                Assert.True((string) table.Rows[i]["Name"].Value == orderedEntities[i].Name);
                Assert.True(table.Rows[i][0].Column.Name == table.DataTable.GetColumns().Single(x => x.Target == 0).Name);
                Assert.True(table.Rows[i][1].Column.Name == table.DataTable.GetColumns().Single(x => x.Target == 1).Name);
            }
        }
    }
}
