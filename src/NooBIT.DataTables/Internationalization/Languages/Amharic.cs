namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Amharic : NamedLanguageSettings
    {
        internal Amharic() : base("am")
        {
            EmptyTable = "ባዶ ሰንጠረዥ";
            Info = $"ከጠቅላላው {TOTAL} ዝርዝሮች ውስጥ ከ {START} እስከ {END} ያሉት ዝርዝር";
            InfoEmpty = "ከጠቅላላው 0 ዝርዝሮች ውስጥ ከ 0 እስከ 0 ያሉት ዝርዝር";
            InfoFiltered = $"(ከጠቅላላው {MAX} የተመረጡ ዝርዝሮች)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"የዝርዝሮች ብዛት {MENU}";
            LoadingRecords = "በማቅረብ ላይ...";
            Processing = "በማቀናበር ላይ...";
            Search = "ፈልግ:";
            ZeroRecords = "ከሚፈለገው ጋር የሚሚሳሰል ዝርዝር አልተገኘም";
            Paginate = new Paginate
            {
                First = "መጀመሪያ",
                Previous = "የበፊቱ",
                Next = "ቀጣዩ",
                Last = "መጨረሻ",
            };
            Aria = new Aria
            {
                SortAscending = ": ከመጀመሪያ ወደ መጨረሻ(ወጪ) አደራደር",
                SortDescending = ": ከመጨረሻ ወደ መጀመሪያ(ወራጅ) አደራደር",
            };
        }
    }
}

