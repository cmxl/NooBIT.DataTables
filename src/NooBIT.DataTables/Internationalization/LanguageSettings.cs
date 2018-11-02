using Newtonsoft.Json;

namespace NooBIT.DataTables.Internationalization
{
    public class LanguageSettings
    {
        public static readonly string START = "_START_";
        public static readonly string END = "_END_";
        public static readonly string TOTAL = "_TOTAL_";
        public static readonly string MAX = "_MAX_";
        public static readonly string MENU = "_MENU_";

        [JsonProperty("sEmptyTable", NullValueHandling = NullValueHandling.Ignore)]
        public string EmptyTable { get; set; }

        [JsonProperty("sInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }

        [JsonProperty("sInfoEmpty", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoEmpty { get; set; }

        [JsonProperty("sInfoFiltered", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoFiltered { get; set; }

        [JsonProperty("sInfoPostFix", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoPostFix { get; set; }

        [JsonProperty("sInfoThousands", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoThousands { get; set; }

        [JsonProperty("sLengthMenu", NullValueHandling = NullValueHandling.Ignore)]
        public string LengthMenu { get; set; }

        [JsonProperty("sLoadingRecords", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadingRecords { get; set; }

        [JsonProperty("sProcessing", NullValueHandling = NullValueHandling.Ignore)]
        public string Processing { get; set; }

        [JsonProperty("sSearch", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        [JsonProperty("sZeroRecords", NullValueHandling = NullValueHandling.Ignore)]
        public string ZeroRecords { get; set; }

        [JsonProperty("oPaginate", NullValueHandling = NullValueHandling.Ignore)]
        public Paginate Paginate { get; set; }

        [JsonProperty("oAria", NullValueHandling = NullValueHandling.Ignore)]
        public Aria Aria { get; set; }

        [JsonProperty("select", NullValueHandling = NullValueHandling.Ignore)]
        public Select Select { get; set; }

        [JsonProperty("buttons", NullValueHandling = NullValueHandling.Ignore)]
        public Buttons Buttons { get; set; }

        public static LanguageSettings FromJson(string json)
        {
            return JsonConvert.DeserializeObject<LanguageSettings>(json);
        }

        public string AsJson(Formatting formatting = Formatting.None)
        {
            return JsonConvert.SerializeObject(this, formatting);
        }

        public override string ToString() => AsJson(Formatting.Indented);
    }

    public class Buttons
    {
        [JsonProperty("print", NullValueHandling = NullValueHandling.Ignore)]
        public string Print { get; set; }

        [JsonProperty("colvis", NullValueHandling = NullValueHandling.Ignore)]
        public string ColVis { get; set; }

        [JsonProperty("copy", NullValueHandling = NullValueHandling.Ignore)]
        public string Copy { get; set; }

        [JsonProperty("copyTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string CopyTitle { get; set; }

        [JsonProperty("copyKeys", NullValueHandling = NullValueHandling.Ignore)]
        public string CopyKeys { get; set; }

        [JsonProperty("copySuccess", NullValueHandling = NullValueHandling.Ignore)]
        public CopySuccess CopySuccess { get; set; }
    }

    public class CopySuccess
    {
        [JsonProperty("_", NullValueHandling = NullValueHandling.Ignore)]
        public string Multiple { get; set; }
        [JsonProperty("1", NullValueHandling = NullValueHandling.Ignore)]
        public string Single { get; set; }
    }

    public class Select
    {
        [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
        public Rows Rows { get; set; }
    }

    public class Rows
    {
        [JsonProperty("_", NullValueHandling = NullValueHandling.Ignore)]
        public string Multiple { get; set; }
        [JsonProperty("1", NullValueHandling = NullValueHandling.Ignore)]
        public string Single { get; set; }
        [JsonProperty("0", NullValueHandling = NullValueHandling.Ignore)]
        public string None { get; set; }
    }

    public class Paginate
    {
        [JsonProperty("sFirst", NullValueHandling = NullValueHandling.Ignore)]
        public string First { get; set; }

        [JsonProperty("sPrevious", NullValueHandling = NullValueHandling.Ignore)]
        public string Previous { get; set; }

        [JsonProperty("sNext", NullValueHandling = NullValueHandling.Ignore)]
        public string Next { get; set; }

        [JsonProperty("sLast", NullValueHandling = NullValueHandling.Ignore)]
        public string Last { get; set; }
    }

    public class Aria
    {
        [JsonProperty("sSortAscending", NullValueHandling = NullValueHandling.Ignore)]
        public string SortAscending { get; set; }

        [JsonProperty("sSortDescending", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDescending { get; set; }
    }
}
