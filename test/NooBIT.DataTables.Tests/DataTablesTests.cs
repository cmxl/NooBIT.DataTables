using NooBIT.DataTables.Rendering;
using NooBIT.DataTables.Tests.Fixtures;
using System.Linq;
using System.Threading.Tasks;
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
            var result = await _fixture.Table.GetAsync(_fixture.ViewModel);
            var renderer = new TableRenderer();
            var table = renderer.Render(_fixture.Table, result);
            var orderedEntities = _fixture.QueryableService.Get().OrderBy(x => x.Id).ToArray();

            Assert.Equal(table.Rows.Length, orderedEntities.Length);
            Assert.Equal(table.Rows[0].Columns.Length, table.DataTable.Columns.Length);

            for (var i = 0; i < orderedEntities.Length; i++)
            {
                Assert.Equal((int)table.Rows[i]["Id"].Value, orderedEntities[i].Id);
                Assert.Equal((string)table.Rows[i]["Name"].Value, orderedEntities[i].Name);
                Assert.Equal(table.Rows[i][0].Column.Name, table.DataTable.Columns.Single(x => x.Target == 0).Name);
                Assert.Equal(table.Rows[i][1].Column.Name, table.DataTable.Columns.Single(x => x.Target == 1).Name);
            }
        }
    }
}
