namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Georgian : NamedLanguageSettings
    {
        internal Georgian() : base("ka")
        {
            EmptyTable = "ცხრილში არ არის მონაცემები";
            Info = $"ნაჩვენებია ჩანაწერები {START}–დან {END}–მდე, {TOTAL} ჩანაწერიდან";
            InfoEmpty = "ნაჩვენებია ჩანაწერები 0–დან 0–მდე, 0 ჩანაწერიდან";
            InfoFiltered = $"(გაფილტრული შედეგი {MAX} ჩანაწერიდან)";
            InfoPostFix = "";
            InfoThousands = ".";
            LengthMenu = $"აჩვენე {MENU} ჩანაწერი";
            LoadingRecords = "იტვირთება...";
            Processing = "მუშავდება...";
            Search = "ძიება:";
            ZeroRecords = "არაფერი მოიძებნა";
            Paginate = new Paginate
            {
                First = "პირველი",
                Previous = "წინა",
                Next = "შემდეგი",
                Last = "ბოლო",
            };
            Aria = new Aria
            {
                SortAscending = ": სვეტის დალაგება ზრდის მიხედვით",
                SortDescending = ": სვეტის დალაგება კლების მიხედვით",
            };
        }
    }
}

