namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Kyrgyz : NamedLanguageSettings
    {
        internal Kyrgyz() : base("ky-Cyrl")
        {
            EmptyTable = "Таблицада эч кандай берилиш жок";
            Info = $"Жалпы {TOTAL} саптын ичинен {START}-саптан {END}-сапка чейинкилер";
            InfoEmpty = "Жалпы 0 саптын ичинен 0-саптан 0-сапка чейинкилер";
            InfoFiltered = $"(жалпы {MAX} саптан фильтрленди)";
            InfoPostFix = "";
            InfoThousands = " ";
            LengthMenu = $"{MENU} саптан көрсөт";
            LoadingRecords = "Жүктөлүүдө...";
            Processing = "Иштеп жатат...";
            Search = "Издөө:";
            ZeroRecords = "Туура келген бир да сап жок";
            Paginate = new Paginate
            {
                First = "Биринчи",
                Previous = "Мурунку",
                Next = "Кийинки",
                Last = "Акыркы",
            };
            Aria = new Aria
            {
                SortAscending = ": иретте",
                SortDescending = ": тескери иретте",
            };
        }
    }
}

