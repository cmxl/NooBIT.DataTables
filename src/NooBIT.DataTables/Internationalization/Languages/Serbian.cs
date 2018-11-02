namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Serbian : NamedLanguageSettings
    {
        internal Serbian() : base("sr-Latn-RS")
        {
            EmptyTable = null;
            Info = $"Prikaz {START} do {END} od ukupno {TOTAL} elemenata";
            InfoEmpty = "Prikaz 0 do 0 od ukupno 0 elemenata";
            InfoFiltered = $"(filtrirano od ukupno {MAX} elemenata)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Prikaži {MENU} elemenata";
            LoadingRecords = null;
            Processing = "Procesiranje u toku...";
            Search = "Pretraga:";
            ZeroRecords = "Nije pronađen nijedan rezultat";
            Paginate = new Paginate
            {
                First = "Početna",
                Previous = "Prethodna",
                Next = "Sledeća",
                Last = "Poslednja",
            };
        }
    }
}

