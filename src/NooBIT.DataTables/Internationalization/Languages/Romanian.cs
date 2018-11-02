namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Romanian : NamedLanguageSettings
    {
        internal Romanian() : base("ro")
        {
            EmptyTable = null;
            Info = $"Afișate de la {START} la {END} din {TOTAL} înregistrări";
            InfoEmpty = "Afișate de la 0 la 0 din 0 înregistrări";
            InfoFiltered = $"(filtrate dintr-un total de {MAX} înregistrări)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Afișează {MENU} înregistrări pe pagină";
            LoadingRecords = null;
            Processing = "Procesează...";
            Search = "Caută:";
            ZeroRecords = "Nu am găsit nimic - ne pare rău";
            Paginate = new Paginate
            {
                First = "Prima",
                Previous = "Precedenta",
                Next = "Următoarea",
                Last = "Ultima",
            };
        }
    }
}

