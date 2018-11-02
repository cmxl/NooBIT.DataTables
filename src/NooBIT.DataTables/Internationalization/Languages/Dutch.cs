namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Dutch : NamedLanguageSettings
    {
        internal Dutch() : base("nl")
        {
            EmptyTable = "Geen resultaten aanwezig in de tabel";
            Info = $"{START} tot {END} van {TOTAL} resultaten";
            InfoEmpty = "Geen resultaten om weer te geven";
            InfoFiltered = $" (gefilterd uit {MAX} resultaten)";
            InfoPostFix = "";
            InfoThousands = ".";
            LengthMenu = $"{MENU} resultaten weergeven";
            LoadingRecords = "Een moment geduld aub - bezig met laden...";
            Processing = "Bezig...";
            Search = "Zoeken:";
            ZeroRecords = "Geen resultaten gevonden";
            Paginate = new Paginate
            {
                First = "Eerste",
                Previous = "Vorige",
                Next = "Volgende",
                Last = "Laatste",
            };
            Aria = new Aria
            {
                SortAscending = ": activeer om kolom oplopend te sorteren",
                SortDescending = ": activeer om kolom aflopend te sorteren",
            };
        }
    }
}

