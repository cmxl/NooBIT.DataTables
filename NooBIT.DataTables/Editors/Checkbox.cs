namespace NooBIT.DataTables.Editors
{
    public class CheckBox : Editor
    {
        public CheckBox() : base(EditorType.CheckBox)
        {
        }

        public bool? IsChecked { get; set; }
    }
}