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
            ViewModel = new AjaxProcessingViewModel
            {
                Columns = new[]
                {
                    new AjaxColumn
                    {
                        Name = "Id",
                        Data = "Id",
                        Orderable = true,
                        Searchable = true,
                        Search = new AjaxSearch
                        {
                            Value = null,
                            Regex = false
                        }
                    },
                    new AjaxColumn
                    {
                        Name = "Name",
                        Data = "Name",
                        Orderable = true,
                        Searchable = true,
                        Search = new AjaxSearch
                        {
                            Value = null,
                            Regex = false
                        }
                    }
                },
                Search = new AjaxSearch
                {
                    Value = null,
                    Regex = false
                },
                Order = new[]
                {
                    new AjaxOrder
                    {
                        Column = 0,
                        Dir = "asc"
                    }
                },
                Draw = 1,
                Length = int.MaxValue,
                Start = 0
            };
        }

        public TestEntityQueryableService QueryableService { get; }

        public TestEntityTable Table { get; }

        public AjaxProcessingViewModel ViewModel { get; }
    }
}