using NooBIT.DataTables.Models;

namespace NooBIT.DataTables.Tests.Models
{
    public class TestAjaxViewModel : AjaxProcessingViewModel
    {
        public TestAjaxViewModel()
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
                };
            Search = new AjaxSearch
            {
                Value = null,
                Regex = false
            };
            Order = new[]
            {
                    new AjaxOrder
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
