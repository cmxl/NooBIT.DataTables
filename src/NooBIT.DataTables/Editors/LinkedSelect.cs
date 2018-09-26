using System.Collections.Generic;

namespace NooBIT.DataTables.Editors
{
    public class LinkedSelect : Editor
    {
        public LinkedSelect() : base(EditorType.LinkedSelect)
        {
        }

        public List<LinkedSelectItem> FilterValues { get; set; } = new List<LinkedSelectItem>();
    }
}