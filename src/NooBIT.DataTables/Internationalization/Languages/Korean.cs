namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Korean : NamedLanguageSettings
    {
        internal Korean() : base("ko")
        {
            EmptyTable = "데이터가 없습니다";
            Info = $"{START} - {END} / {TOTAL}";
            InfoEmpty = "0 - 0 / 0";
            InfoFiltered = $"(총 {MAX} 개)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"페이지당 줄수 {MENU}";
            LoadingRecords = "읽는중...";
            Processing = "처리중...";
            Search = "검색:";
            ZeroRecords = "검색 결과가 없습니다";
            Paginate = new Paginate
            {
                First = "처음",
                Previous = "이전",
                Next = "다음",
                Last = "마지막",
            };
            Aria = new Aria
            {
                SortAscending = ": 오름차순 정렬",
                SortDescending = ": 내림차순 정렬",
            };
        }
    }
}

