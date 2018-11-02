namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Italian : NamedLanguageSettings
    {
        internal Italian() : base("it-it")
        {
            EmptyTable = "Nessun dato presente nella tabella";
            Info = $"Vista da {START} a {END} di {TOTAL} elementi";
            InfoEmpty = "Vista da 0 a 0 di 0 elementi";
            InfoFiltered = $"(filtrati da {MAX} elementi totali)";
            InfoPostFix = "";
            InfoThousands = ".";
            LengthMenu = $"Visualizza {MENU} elementi";
            LoadingRecords = "Caricamento...";
            Processing = "Elaborazione...";
            Search = "Cerca:";
            ZeroRecords = "La ricerca non ha portato alcun risultato.";
            Paginate = new Paginate
            {
                First = "Inizio",
                Previous = "Precedente",
                Next = "Successivo",
                Last = "Fine",
            };
            Aria = new Aria
            {
                SortAscending = ": attiva per ordinare la colonna in ordine crescente",
                SortDescending = ": attiva per ordinare la colonna in ordine decrescente",
            };
        }
    }
}

