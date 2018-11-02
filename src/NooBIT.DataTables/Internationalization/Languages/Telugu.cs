namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Telugu : NamedLanguageSettings
    {
        internal Telugu() : base("te")
        {
            EmptyTable = "పట్టికలో డేటా లేదు.";
            Info = $"మొత్తం {TOTAL} ఎంట్రీలులో {START} నుండి {END} వరకు చూపిస్తున్నాం";
            InfoEmpty = "చూపిస్తున్నాం 0 నుండి 0 వరకు 0 ఎంట్రీలు లో";
            InfoFiltered = $"( {MAX} ఎంట్రీలులో నుండి వడపోయాబడినవి)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $" {MENU} ఎంట్రీలు చూపించు";
            LoadingRecords = "లోడ్ అవుతుంది ...";
            Processing = "ప్రాసెస్ చేయబడుతుంది...";
            Search = "వెతుకు:";
            ZeroRecords = "మ్యాచింగ్ రికార్డులు లేవు";
            Paginate = new Paginate
            {
                First = "మొదటి",
                Previous = "మునుపటి",
                Next = "తర్వాత",
                Last = "చివరి",
            };
            Aria = new Aria
            {
                SortAscending = ": నిలువరుసను ఆరోహణ క్రమం అమర్చండి",
                SortDescending = ": నిలువరుసను అవరోహణ క్రమం అమర్చండి",
            };
        }
    }
}

