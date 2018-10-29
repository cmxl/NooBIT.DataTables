using Newtonsoft.Json;

namespace NooBIT.DataTables.Language
{

    public class LanguageSettings
    {
        public static readonly LanguageSettings German = new LanguageSettings
        {
            EmptyTable = "Keine Daten in der Tabelle vorhanden",
            Info = "_START_ bis _END_ von _TOTAL_ Einträgen",
            InfoEmpty = "0 bis 0 von 0 Einträgen",
            InfoFiltered = "(gefiltert von _MAX_ Einträgen)",
            InfoPostFix = string.Empty,
            InfoThousands = ".",
            LengthMenu = "_MENU_ Einträge anzeigen",
            LoadingRecords = "Wird geladen...",
            Processing = "Bitte warten...",
            Search = "Suchen",
            ZeroRecords = "Keine Einträge vorhanden.",
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