namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Chinese : NamedLanguageSettings
    {
        internal Chinese() : base("zh-Hans")
        {
            EmptyTable = "表中数据为空";
            Info = $"显示第 {START} 至 {END} 项结果，共 {TOTAL} 项";
            InfoEmpty = "显示第 0 至 0 项结果，共 0 项";
            InfoFiltered = $"(由 {MAX} 项结果过滤)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"显示 {MENU} 项结果";
            LoadingRecords = "载入中...";
            Processing = "处理中...";
            Search = "搜索:";
            ZeroRecords = "没有匹配结果";
            Paginate = new Paginate
            {
                First = "首页",
                Previous = "上页",
                Next = "下页",
                Last = "末页",
            };
            Aria = new Aria
            {
                SortAscending = ": 以升序排列此列",
                SortDescending = ": 以降序排列此列",
            };
        }
    }
}

