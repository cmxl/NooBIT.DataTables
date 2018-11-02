namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Armenian : NamedLanguageSettings
    {
        internal Armenian() : base("hy")
        {
            EmptyTable = "Տվյալները բացակայում են";
            Info = $"Ցուցադրված են {START}-ից {END} արդյունքները ընդհանուր {TOTAL}-ից";
            InfoEmpty = "Արդյունքներ գտնված չեն";
            InfoFiltered = $"(ֆիլտրվել է ընդհանուր {MAX} արդյունքներից)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Ցուցադրել {MENU} արդյունքներ մեկ էջում";
            LoadingRecords = "Բեռնվում է ...";
            Processing = "Կատարվում է...";
            Search = "Փնտրել";
            ZeroRecords = "Հարցմանը համապատասխանող արդյունքներ չկան";
            Paginate = new Paginate
            {
                First = "Առաջին էջ",
                Previous = "Նախորդ էջ",
                Next = "Հաջորդ էջ",
                Last = "Վերջին էջ",
            };
            Aria = new Aria
            {
                SortAscending = ": ակտիվացրեք աճման կարգով դասավորելու համար",
                SortDescending = ": ակտիվացրեք նվազման կարգով դասավորելու համար",
            };
        }
    }
}

