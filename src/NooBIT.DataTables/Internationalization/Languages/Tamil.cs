namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Tamil : NamedLanguageSettings
    {
        internal Tamil() : base("ta")
        {
            EmptyTable = "அட்டவணையில் தரவு கிடைக்கவில்லை";
            Info = $"உள்ளீடுகளை் {START} முதல {END} உள்ள {TOTAL} காட்டும்";
            InfoEmpty = "0 உள்ளீடுகளை 0 0 காட்டும்";
            InfoFiltered = $"({MAX} மொத்த உள்ளீடுகளை இருந்து வடிகட்டி)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"{MENU} காண்பி";
            LoadingRecords = "ஏற்றுகிறது ...";
            Processing = "செயலாக்க ...";
            Search = "தேடல்:";
            ZeroRecords = "பொருத்தமான பதிவுகள் இல்லை";
            Paginate = new Paginate
            {
                First = "முதல்",
                Previous = "முந்தைய",
                Next = "அடுத்து",
                Last = "இறுதி",
            };
            Aria = new Aria
            {
                SortAscending = ": நிரலை ஏறுவரிசையில் வரிசைப்படுத்த செயல்படுத்த",
                SortDescending = ": நிரலை இறங்கு வரிசைப்படுத்த செயல்படுத்த",
            };
        }
    }
}

