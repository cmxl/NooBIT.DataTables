namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Ukrainian : NamedLanguageSettings
    {
        internal Ukrainian() : base("uk")
        {
            EmptyTable = null;
            Info = $"Записи з {START} по {END} із {TOTAL} записів";
            InfoEmpty = "Записи з 0 по 0 із 0 записів";
            InfoFiltered = $"(відфільтровано з {MAX} записів)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Показати {MENU} записів";
            LoadingRecords = null;
            Processing = "Зачекайте...";
            Search = "Пошук:";
            ZeroRecords = "Записи відсутні.";
            Paginate = new Paginate
            {
                First = "Перша",
                Previous = "Попередня",
                Next = "Наступна",
                Last = "Остання",
            };
            Aria = new Aria
            {
                SortAscending = ": активувати для сортування стовпців за зростанням",
                SortDescending = ": активувати для сортування стовпців за спаданням",
            };
        }
    }
}

