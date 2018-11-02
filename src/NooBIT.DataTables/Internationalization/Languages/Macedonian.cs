namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Macedonian : NamedLanguageSettings
    {
        internal Macedonian() : base("mk")
        {
            EmptyTable = "Нема податоци во табелата";
            Info = $"Прикажани {START} до {END} од {TOTAL} записи";
            InfoEmpty = "Прикажани 0 до 0 од 0 записи";
            InfoFiltered = $"(филтрирано од вкупно {MAX} записи)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Прикажи {MENU} записи";
            LoadingRecords = "Вчитување...";
            Processing = "Процесирање...";
            Search = "Барај";
            ZeroRecords = "Не се пронајдени записи";
            Paginate = new Paginate
            {
                First = "Почетна",
                Previous = "Претходна",
                Next = "Следна",
                Last = "Последна",
            };
        }
    }
}

