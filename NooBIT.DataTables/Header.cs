using NooBIT.DataTables.Editors;

namespace NooBIT.DataTables
{
    public class Header
    {
        public string DisplayName { get; set; }
        public Help Help { get; set; }
        public bool DisplayHelp => !string.IsNullOrWhiteSpace(Help?.HelpUrl);
        public Editor Filter { get; set; } = new TextBox();
    }

    public class Help
    {
        public string HelpUrl { get; set; }
        public string HelpImage { get; set; }
        public string Title { get; set; }
    }
}