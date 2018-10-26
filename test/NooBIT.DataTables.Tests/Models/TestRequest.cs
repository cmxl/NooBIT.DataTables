using NooBIT.DataTables.Models;

namespace NooBIT.DataTables.Tests.Models
{
    public class TestRequest : DataTableRequest
    {
        public TestRequest()
        {
            Columns = new[]
                {
                    new ColumnRequest
                    {
                        Name = "Id",
                        Data = "Id",
                        Orderable = true,
                        Searchable = true,
                        Search = new SearchRequest
                        {
                            Value = null,
                            Regex = false
                        }
                    },
                    new ColumnRequest
                    {
                        Name = "Name",
                        Data = "Name",
                        Orderable = true,
                        Searchable = true,
                        Search = new SearchRequest
                        {
                            Value = null,
                            Regex = false
                        }
                    }
                };
            Search = new SearchRequest
            {
                Value = null,
                Regex = false
            };
            Order = new[]
            {
                    new OrderRequest
                    {
                        Column = 0,
                        Dir = "asc"
                    }
                };
            Draw = 1;
            Length = int.MaxValue;
            Start = 0;
        }
    }
}
