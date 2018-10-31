using Newtonsoft.Json;

namespace NooBIT.DataTables.Language
{
    public class LanguageSettings
    {
        public static readonly string START = "_START_";
        public static readonly string END = "_END_";
        public static readonly string TOTAL = "_TOTAL_";
        public static readonly string MAX = "_MAX_";
        public static readonly string MENU = "_MENU_";

        public static readonly LanguageSettings English = new LanguageSettings
        {
            EmptyTable = "No data available in table",
            Info = $"Showing {START} to {END} of {TOTAL} entries",
            InfoEmpty = "Showing 0 to 0 of 0 entries",
            InfoFiltered = $"(filtered from {MAX} total entries)",
            InfoPostFix = string.Empty,
            InfoThousands = ",",
            LengthMenu = $"Show {MENU} entries",
            LoadingRecords = "Loading...",
            Processing = "Processing...",
            Search = "Search:",
            ZeroRecords = "No matching records found",
            Paginate = new Paginate
            {
                First = "First",
                Last = "Last",
                Next = "Next",
                Previous = "Previous"
            },
            Aria = new Aria
            {
                SortAscending = ": activate to sort column ascending",
                SortDescending = ": activate to sort column descending"
            }
        };

        public static readonly LanguageSettings German = new LanguageSettings
        {
            EmptyTable = "Keine Daten in der Tabelle vorhanden",
            Info = $"{START} bis {END} von {TOTAL} Einträgen",
            InfoEmpty = "Keine Daten vorhanden",
            InfoFiltered = $"(gefiltert von {MAX} Einträgen)",
            InfoPostFix = string.Empty,
            InfoThousands = ".",
            LengthMenu = $"{MENU} Einträge anzeigen",
            LoadingRecords = "Wird geladen ..",
            Processing = "Bitte warten ..",
            Search = "Suchen",
            ZeroRecords = "Keine Einträge vorhanden",
            Paginate = new Paginate
            {
                First = "Erste",
                Last = "Letzte",
                Next = "Nächste",
                Previous = "Zurück"
            },
            Aria = new Aria
            {
                SortAscending = ": aktivieren, um Spalte aufsteigend zu sortieren",
                SortDescending = ": aktivieren, um Spalte absteigend zu sortieren"
            },
            Select = new Select
            {
                Rows = new Rows
                {
                    Multiple = "%d Zeilen ausgewählt",
                    None = string.Empty,
                    Single = "1 Zeile ausgewählt"
                }
            },
            Buttons = new Buttons
            {
                Print = "Drucken",
                ColVis = "Spalten",
                Copy = "Kopieren",
                CopyTitle = "In Zwischenablage kopieren",
                CopyKeys = "Taste <i>ctrl</i> oder <i>\u2318</i> + <i>C</i> um Tabelle<br>in Zwischenspeicher zu kopieren.<br><br>Um abzubrechen die Nachricht anklicken oder Escape drücken.",
                CopySuccess = new CopySuccess
                {
                    Multiple = "%d Zeilen kopiert",
                    Single = "1 Zeile kopiert"
                }
            }
        };

        [JsonProperty("sEmptyTable")]
        public string EmptyTable { get; set; }

        [JsonProperty("sInfo")]
        public string Info { get; set; }

        [JsonProperty("sInfoEmpty")]
        public string InfoEmpty { get; set; }

        [JsonProperty("sInfoFiltered")]
        public string InfoFiltered { get; set; }

        [JsonProperty("sInfoPostFix")]
        public string InfoPostFix { get; set; }

        [JsonProperty("sInfoThousands")]
        public string InfoThousands { get; set; }

        [JsonProperty("sLengthMenu")]
        public string LengthMenu { get; set; }

        [JsonProperty("sLoadingRecords")]
        public string LoadingRecords { get; set; }

        [JsonProperty("sProcessing")]
        public string Processing { get; set; }

        [JsonProperty("sSearch")]
        public string Search { get; set; }

        [JsonProperty("sZeroRecords")]
        public string ZeroRecords { get; set; }

        [JsonProperty("oPaginate")]
        public Paginate Paginate { get; set; }

        [JsonProperty("oAria")]
        public Aria Aria { get; set; }

        [JsonProperty("select")]
        public Select Select { get; set; }

        [JsonProperty("buttons")]
        public Buttons Buttons { get; set; }

        public static LanguageSettings FromJson(string json)
        {
            return JsonConvert.DeserializeObject<LanguageSettings>(json);
        }
    }

    public class Buttons
    {
        [JsonProperty("print")]
        public string Print { get; set; }

        [JsonProperty("colvis")]
        public string ColVis { get; set; }

        [JsonProperty("copy")]
        public string Copy { get; set; }

        [JsonProperty("copyTitle")]
        public string CopyTitle { get; set; }

        [JsonProperty("copyKeys")]
        public string CopyKeys { get; set; }

        [JsonProperty("copySuccess")]
        public CopySuccess CopySuccess { get; set; }
    }

    public class CopySuccess
    {
        [JsonProperty("_")]
        public string Multiple { get; set; }
        [JsonProperty("1")]
        public string Single { get; set; }
    }

    public class Select
    {
        [JsonProperty("rows")]
        public Rows Rows { get; set; }
    }

    public class Rows
    {
        [JsonProperty("_")]
        public string Multiple { get; set; }
        [JsonProperty("1")]
        public string Single { get; set; }
        [JsonProperty("0")]
        public string None { get; set; }
    }

    public class Paginate
    {
        [JsonProperty("sFirst")]
        public string First { get; set; }

        [JsonProperty("sPrevious")]
        public string Previous { get; set; }

        [JsonProperty("sNext")]
        public string Next { get; set; }

        [JsonProperty("sLast")]
        public string Last { get; set; }
    }

    public class Aria
    {
        [JsonProperty("sSortAscending")]
        public string SortAscending { get; set; }

        [JsonProperty("sSortDescending")]
        public string SortDescending { get; set; }
    }
}