namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class NorwegianNynorsk : NamedLanguageSettings
    {
        internal NorwegianNynorsk() : base("nn")
        {
            EmptyTable = "Inga data tilgjengeleg i tabellen";
            Info = $"Syner {START} til {END} av {TOTAL} linjer";
            InfoEmpty = "Syner 0 til 0 av 0 linjer";
            InfoFiltered = $"(filtrert frå {MAX} totalt antal linjer)";
            InfoPostFix = "";
            InfoThousands = " ";
            LengthMenu = $"Syn {MENU} linjer";
            LoadingRecords = "Lastar...";
            Processing = "Lastar...";
            Search = "S&oslash;k:";
            ZeroRecords = "Inga linjer treff p&aring; s&oslash;ket";
            Paginate = new Paginate
            {
                First = "Fyrste",
                Previous = "Forrige",
                Next = "Neste",
                Last = "Siste",
            };
            Aria = new Aria
            {
                SortAscending = ": aktiver for å sortere kolonna stigande",
                SortDescending = ": aktiver for å sortere kolonna synkande",
            };
        }
    }
}

