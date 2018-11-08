using NooBIT.DataTables.Attributes;

namespace NooBIT.DataTables.Sample.Model
{
    public class SampleData
    {
        [ColumnOrder(0)]
        public int Id { get; set; }

        [ColumnOrder(1)]
        public string Name { get; set; }
    }
}