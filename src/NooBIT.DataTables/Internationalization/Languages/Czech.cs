namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Czech : NamedLanguageSettings
    {
        internal Czech() : base("cs")
        {
            EmptyTable = "Tabulka neobsahuje žádná data";
            Info = $"Zobrazuji {START} až {END} z celkem {TOTAL} záznamů";
            InfoEmpty = "Zobrazuji 0 až 0 z 0 záznamů";
            InfoFiltered = $"(filtrováno z celkem {MAX} záznamů)";
            InfoPostFix = "";
            InfoThousands = " ";
            LengthMenu = $"Zobraz záznamů {MENU}";
            LoadingRecords = "Načítám...";
            Processing = "Provádím...";
            Search = "Hledat:";
            ZeroRecords = "Žádné záznamy nebyly nalezeny";
            Paginate = new Paginate
            {
                First = "První",
                Previous = "Předchozí",
                Next = "Další",
                Last = "Poslední",
            };
            Aria = new Aria
            {
                SortAscending = ": aktivujte pro řazení sloupce vzestupně",
                SortDescending = ": aktivujte pro řazení sloupce sestupně",
            };
        }
    }
}

