namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Bulgarian : NamedLanguageSettings
    {
        internal Bulgarian() : base("bg")
        {
            EmptyTable = null;
            Info = $"Показване на резултати от {START} до {END} от общо {TOTAL}";
            InfoEmpty = "Показване на резултати от 0 до 0 от общо 0";
            InfoFiltered = $"(филтрирани от общо {MAX} резултата)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Показване на {MENU} резултата";
            LoadingRecords = null;
            Processing = "Обработка на резултатите...";
            Search = "Търсене:";
            ZeroRecords = "Няма намерени резултати";
            Paginate = new Paginate
            {
                First = "Първа",
                Previous = "Предишна",
                Next = "Следваща",
                Last = "Последна",
            };
        }
    }
}

