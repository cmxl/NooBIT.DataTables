namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Icelandic : NamedLanguageSettings
    {
        internal Icelandic() : base("is")
        {
            EmptyTable = "Engin gögn eru í þessari töflu";
            Info = $"Sýni {START} til {END} af {TOTAL} færslum";
            InfoEmpty = "Sýni 0 til 0 af 0 færslum";
            InfoFiltered = $"(síað út frá {MAX} færslum)";
            InfoPostFix = "";
            InfoThousands = ".";
            LengthMenu = $"Sýna {MENU} færslur";
            LoadingRecords = "Hleð...";
            Processing = "Úrvinnsla...";
            Search = "Leita:";
            ZeroRecords = "Engar færslur fundust";
            Paginate = new Paginate
            {
                First = "Fyrsta",
                Previous = "Fyrri",
                Next = "Næsta",
                Last = "Síðasta",
            };
            Aria = new Aria
            {
                SortAscending = ": virkja til að raða dálki í hækkandi röð",
                SortDescending = ": virkja til að raða dálki lækkandi í röð",
            };
        }
    }
}

