namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Hungarian : NamedLanguageSettings
    {
        internal Hungarian() : base("hu")
        {
            EmptyTable = "Nincs rendelkezésre álló adat";
            Info = $"Találatok: {START} - {END} Összesen: {TOTAL}";
            InfoEmpty = "Nulla találat";
            InfoFiltered = $"({MAX} összes rekord közül szűrve)";
            InfoPostFix = "";
            InfoThousands = " ";
            LengthMenu = $"{MENU} találat oldalanként";
            LoadingRecords = "Betöltés...";
            Processing = "Feldolgozás...";
            Search = "Keresés:";
            ZeroRecords = "Nincs a keresésnek megfelelő találat";
            Paginate = new Paginate
            {
                First = "Első",
                Previous = "Előző",
                Next = "Következő",
                Last = "Utolsó",
            };
            Aria = new Aria
            {
                SortAscending = ": aktiválja a növekvő rendezéshez",
                SortDescending = ": aktiválja a csökkenő rendezéshez",
            };
            Select = new Select
            {
                Rows = new Rows
                {
                    Multiple = "%d sor kiválasztva",
                    Single = "1 sor kiválasztva",
                    None = "",
                },
            };
            Buttons = new Buttons
            {
                Print = "Nyomtatás",
                ColVis = "Oszlopok",
                Copy = "Másolás",
                CopyTitle = "Vágólapra másolás",
                CopyKeys = null,
                CopySuccess = new CopySuccess
                {
                    Multiple = "%d sor másolva",
                    Single = "1 sor másolva",
                },
            };
        }
    }
}

