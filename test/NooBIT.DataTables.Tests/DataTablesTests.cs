using System.Linq;
using System.Threading.Tasks;
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
        public async Task Table_Rendering_Does_Not_Crash()
        {
            var result = await _fixture.Table.GetAsync(_fixture.Request);
            var renderer = new TableRenderer();
            var table = renderer.Render(_fixture.Table, result);
            var orderedEntities = _fixture.QueryableService.Get().OrderBy(x => x.Id).ToArray();

            Assert.Equal(orderedEntities.Length, table.Rows.Length);
            for (int i = 0; i < table.Rows.Length; i++)
            {
                Assert.Equal(table.DataTable.Columns.Length, table.Rows[i].Columns.Length);
                Assert.Equal(orderedEntities[i].Id, (int)table.Rows[i]["Id"].Value);
                Assert.Equal(orderedEntities[i].Name, (string)table.Rows[i]["Name"].Value);
                for (int j = 0; j < table.Columns.Length; j++)
                {
                    Assert.Equal(table.DataTable.Columns.Single(x => x.Target == j).Name, table.Rows[i][j].Column.Name);
                    Assert.Equal(table.DataTable.Columns[j].Name, table.Rows[i][j].Column.Name);
                }
            }
        }
    }
}
