namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Slovak : NamedLanguageSettings
    {
        internal Slovak() : base("sk")
        {
            EmptyTable = "Nie sú k dispozícii žiadne dáta";
            Info = $"Záznamy {START} až {END} z celkom {TOTAL}";
            InfoEmpty = "Záznamy 0 až 0 z celkom 0 ";
            InfoFiltered = $"(vyfiltrované spomedzi {MAX} záznamov)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Zobraz {MENU} záznamov";
            LoadingRecords = "Načítavam...";
            Processing = "Spracúvam...";
            Search = "Hľadať:";
            ZeroRecords = "Nenašli sa žiadne vyhovujúce záznamy";
            Paginate = new Paginate
            {
                First = "Prvá",
                Previous = "Predchádzajúca",
                Next = "Nasledujúca",
                Last = "Posledná",
            };
            Aria = new Aria
            {
                SortAscending = ": aktivujte na zoradenie stĺpca vzostupne",
                SortDescending = ": aktivujte na zoradenie stĺpca zostupne",
            };
        }
    }
}

