namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Bangla : NamedLanguageSettings
    {
        internal Bangla() : base("bn-BD")
        {
            EmptyTable = null;
            Info = $"{TOTAL} টা এন্ট্রির মধ্যে {START} থেকে {END} পর্যন্ত দেখানো হচ্ছে";
            InfoEmpty = "কোন এন্ট্রি খুঁজে পাওয়া যায় নাই";
            InfoFiltered = $"(মোট {MAX} টা এন্ট্রির মধ্যে থেকে বাছাইকৃত)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"{MENU} টা এন্ট্রি দেখাও";
            LoadingRecords = null;
            Processing = "প্রসেসিং হচ্ছে...";
            Search = "অনুসন্ধান:";
            ZeroRecords = "আপনি যা অনুসন্ধান করেছেন তার সাথে মিলে যাওয়া কোন রেকর্ড খুঁজে পাওয়া যায় নাই";
            Paginate = new Paginate
            {
                First = "প্রথমটা",
                Previous = "আগেরটা",
                Next = "পরবর্তীটা",
                Last = "শেষেরটা",
            };
        }
    }
}

