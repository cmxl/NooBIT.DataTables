namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Slovenian : NamedLanguageSettings
    {
        internal Slovenian() : base("sl")
        {
            EmptyTable = "Nobenih podatkov ni na voljo";
            Info = $"Prikazujem {START} do {END} od {TOTAL} zapisov";
            InfoEmpty = "Prikazujem 0 do 0 od 0 zapisov";
            InfoFiltered = $"(filtrirano od {MAX} vseh zapisov)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Prikaži {MENU} zapisov";
            LoadingRecords = "Nalagam...";
            Processing = "Obdelujem...";
            Search = "Išči:";
            ZeroRecords = "Nobeden zapis ne ustreza";
            Paginate = new Paginate
            {
                First = "Prvi",
                Previous = "Pred.",
                Next = "Nasl.",
                Last = "Zadnji",
            };
            Aria = new Aria
            {
                SortAscending = ": vključite za naraščujoči sort",
                SortDescending = ": vključite za padajoči sort",
            };
        }
    }
}

