namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class NorwegianBokmal : NamedLanguageSettings
    {
        internal NorwegianBokmal() : base("nb")
        {
            EmptyTable = "Ingen data tilgjengelig i tabellen";
            Info = $"Viser {START} til {END} av {TOTAL} linjer";
            InfoEmpty = "Viser 0 til 0 av 0 linjer";
            InfoFiltered = $"(filtrert fra {MAX} totalt antall linjer)";
            InfoPostFix = "";
            InfoThousands = " ";
            LengthMenu = $"Vis {MENU} linjer";
            LoadingRecords = "Laster...";
            Processing = "Laster...";
            Search = "S&oslash;k:";
            ZeroRecords = "Ingen linjer matcher s&oslash;ket";
            Paginate = new Paginate
            {
                First = "F&oslash;rste",
                Previous = "Forrige",
                Next = "Neste",
                Last = "Siste",
            };
            Aria = new Aria
            {
                SortAscending = ": aktiver for å sortere kolonnen stigende",
                SortDescending = ": aktiver for å sortere kolonnen synkende",
            };
        }
    }
}

