namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Japanese : NamedLanguageSettings
    {
        internal Japanese() : base("ja")
        {
            EmptyTable = "テーブルにデータがありません";
            Info = $" {TOTAL} 件中 {START} から {END} まで表示";
            InfoEmpty = " 0 件中 0 から 0 まで表示";
            InfoFiltered = $"（全 {MAX} 件より抽出）";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"{MENU} 件表示";
            LoadingRecords = "読み込み中...";
            Processing = "処理中...";
            Search = "検索:";
            ZeroRecords = "一致するレコードがありません";
            Paginate = new Paginate
            {
                First = "先頭",
                Previous = "前",
                Next = "次",
                Last = "最終",
            };
            Aria = new Aria
            {
                SortAscending = ": 列を昇順に並べ替えるにはアクティブにする",
                SortDescending = ": 列を降順に並べ替えるにはアクティブにする",
            };
        }
    }
}

