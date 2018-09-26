namespace NooBIT.DataTables.Editors
{
    public class Button : Editor
    {
        public Button(ButtonType buttonType) : base(EditorType.Button)
        {
            ButtonType = buttonType;
        }

        public ButtonType ButtonType { get; }
        public string Text { get; set; }
        public string OnClick { get; set; }
    }
}