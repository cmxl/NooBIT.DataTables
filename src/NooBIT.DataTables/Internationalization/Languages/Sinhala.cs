namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Sinhala : NamedLanguageSettings
    {
        internal Sinhala() : base("si")
        {
            EmptyTable = "වගුවේ දත්ත කිසිවක් නොමැත";
            Info = $"{TOTAL} න් {START} සිට {END} දක්වා";
            InfoEmpty = "0 න් 0 සිට 0 දක්වා";
            InfoFiltered = $"({MAX} න් තෝරාගත් )";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"{MENU} ක් පෙන්වන්න";
            LoadingRecords = "පූරණය වෙමින් පවතී...";
            Processing = "සැකසෙමින් පවතී...";
            Search = "සොයන්න :";
            ZeroRecords = "ගැලපෙන වාර්තා නොමැත.";
            Paginate = new Paginate
            {
                First = "පළමු",
                Previous = "පසුගිය",
                Next = "ඊළග",
                Last = "අන්තිම",
            };
            Aria = new Aria
            {
                SortAscending = ": තීරුව ආරෝහනව තෝරන්න",
                SortDescending = ": තීරුව අවරෝහනව තෝරන්න",
            };
        }
    }
}

