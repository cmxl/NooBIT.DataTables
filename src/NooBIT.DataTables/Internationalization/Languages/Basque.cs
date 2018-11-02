namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Basque : NamedLanguageSettings
    {
        internal Basque() : base("eu")
        {
            EmptyTable = "Taula hontan ez dago inongo datu erabilgarririk";
            Info = $"{START} -etik {END} -erako erregistroak erakusten, guztira {TOTAL} erregistro";
            InfoEmpty = "0tik 0rako erregistroak erakusten, guztira 0 erregistro";
            InfoFiltered = $"(guztira {MAX} erregistro iragazten)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Erakutsi {MENU} erregistro";
            LoadingRecords = "Abiarazten...";
            Processing = "Prozesatzen...";
            Search = "Aurkitu:";
            ZeroRecords = "Ez da emaitzarik aurkitu";
            Paginate = new Paginate
            {
                First = "Lehena",
                Previous = "Aurrekoa",
                Next = "Hurrengoa",
                Last = "Azkena",
            };
            Aria = new Aria
            {
                SortAscending = ": Zutabea goranzko eran ordenatzeko aktibatu ",
                SortDescending = ": Zutabea beheranzko eran ordenatzeko aktibatu",
            };
        }
    }
}

