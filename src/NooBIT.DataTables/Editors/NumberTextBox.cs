namespace NooBIT.DataTables.Editors
{
    public class NumberTextBox : TextBox
    {
        public NumberTextBox()
        {
            EditorType = EditorType.Number;
        }

        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
    }
}