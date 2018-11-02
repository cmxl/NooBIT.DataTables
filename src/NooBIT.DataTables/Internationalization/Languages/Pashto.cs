namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Pashto : NamedLanguageSettings
    {
        internal Pashto() : base("ps-AF")
        {
            EmptyTable = "جدول خالي دی";
            Info = $"د {START} څخه تر {END} پوري، له ټولو {TOTAL} څخه";
            InfoEmpty = "د 0 څخه تر 0 پوري، له ټولو 0 څخه";
            InfoFiltered = $"(لټول سوي له ټولو {MAX} څخه)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"{MENU} کتاره وښايه";
            LoadingRecords = "منتظر اوسئ...";
            Processing = "منتظر اوسئ...";
            Search = "لټون:";
            ZeroRecords = "د لټون مطابق معلومات و نه موندل سول";
            Paginate = new Paginate
            {
                First = "لومړۍ",
                Previous = "شاته",
                Next = "بله",
                Last = "وروستۍ",
            };
            Aria = new Aria
            {
                SortAscending = ": په صعودي ډول مرتبول",
                SortDescending = ": په نزولي ډول مرتبول",
            };
        }
    }
}

