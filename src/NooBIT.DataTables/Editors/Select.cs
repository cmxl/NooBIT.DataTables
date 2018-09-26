using System.Collections.Generic;

namespace NooBIT.DataTables.Editors
{
    public class Select : Editor
    {
        public Select() : base(EditorType.Select)
        {
        }

        public List<SelectItem> FilterValues { get; set; } = new List<SelectItem>();
    }
}