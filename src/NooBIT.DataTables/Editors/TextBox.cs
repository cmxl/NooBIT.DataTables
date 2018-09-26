namespace NooBIT.DataTables.Editors
{
    public class TextBox : Editor
    {
        public TextBox() : base(EditorType.Text)
        {
        }

        public string PlaceHolder { get; set; }
    }
}