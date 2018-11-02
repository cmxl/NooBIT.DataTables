using NooBIT.DataTables.Internationalization;
using NooBIT.DataTables.Sample.Model;

namespace NooBIT.DataTables.Sample.ViewModels
{
    public class SampleViewModel
    {
        public IDataTable<SampleData> Table { get; set; }
        public NamedLanguageSettings Language { get; set; }
    }
}
