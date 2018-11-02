namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Uzbek : NamedLanguageSettings
    {
        internal Uzbek() : base("uz-Latn")
        {
            EmptyTable = "Ma'lumot yo'q";
            Info = $"Umumiy {TOTAL} yozuvlarlardan {START} dan {END} gachasi ko'rsatilmoqda";
            InfoEmpty = "Umumiy 0 yozuvlardan 0 dan 0 gachasi ko'rsatilmoqda";
            InfoFiltered = $"({MAX} yozuvlardan filtrlandi)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"{MENU} ta yozuvlarni ko'rsat";
            LoadingRecords = "Yozuvlar yuklanmoqda...";
            Processing = "Ishlayapman...";
            Search = "Izlash:";
            ZeroRecords = "Ma'lumot yo'q.";
            Paginate = new Paginate
            {
                First = "Birinchi",
                Previous = "Avvalgi",
                Next = "Keyingi",
                Last = "Son'ggi",
            };
            Aria = new Aria
            {
                SortAscending = ": to'g'ri tartiblash",
                SortDescending = ": teskari tartiblash",
            };
        }
    }
}

