namespace NooBIT.DataTables.Editors
{
    public abstract class Editor
    {
        protected Editor(EditorType editorType)
        {
            EditorType = editorType;
        }

        public EditorType EditorType { get; protected set; }

        public string Name { get; set; }
        public string Id { get; set; }
        public string Classes { get; set; }
        public string DefaultValue { get; set; }
        public string Title { get; set; }
        public bool Disabled { get; set; }
        public bool Required { get; set; }
    }
}