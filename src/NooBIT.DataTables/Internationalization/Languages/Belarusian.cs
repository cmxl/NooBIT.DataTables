namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Belarusian : NamedLanguageSettings
    {
        internal Belarusian() : base("be")
        {
            EmptyTable = null;
            Info = $"Запісы з {START} па {END} з {TOTAL} запісаў";
            InfoEmpty = "Запісы з 0 па 0 з 0 запісаў";
            InfoFiltered = $"(адфільтравана з {MAX} запісаў)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Паказваць {MENU} запісаў";
            LoadingRecords = null;
            Processing = "Пачакайце...";
            Search = "Пошук:";
            ZeroRecords = "Запісы адсутнічаюць.";
            Paginate = new Paginate
            {
                First = "Першая",
                Previous = "Папярэдняя",
                Next = "Наступная",
                Last = "Апошняя",
            };
            Aria = new Aria
            {
                SortAscending = ": актываваць для сартавання слупка па ўзрастанні",
                SortDescending = ": актываваць для сартавання слупка па змяншэнні",
            };
        }
    }
}

