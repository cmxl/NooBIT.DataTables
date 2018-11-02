namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Khmer : NamedLanguageSettings
    {
        internal Khmer() : base("km")
        {
            EmptyTable = "មិនមានទិន្នន័យក្នុងតារាងនេះទេ";
            Info = $"បង្ហាញជួរទី {START} ដល់ទី {END} ក្នុងចំណោម {TOTAL} ជួរ";
            InfoEmpty = "បង្ហាញជួរទី 0 ដល់ទី 0 ក្នុងចំណោម 0 ជួរ";
            InfoFiltered = $"(បានចម្រាញ់ចេញពីទិន្នន័យសរុប {MAX} ជួរ)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"បង្ហាញ {MENU} ជួរ";
            LoadingRecords = "កំពុងផ្ទុក...";
            Processing = "កំពុងដំណើរការ...";
            Search = "ស្វែងរក:";
            ZeroRecords = "មិនមានទិន្នន័យត្រូវតាមលក្ខខណ្ឌស្វែងរកទេ";
            Paginate = new Paginate
            {
                First = "ដំបូងគេ",
                Previous = "ក្រោយ",
                Next = "បន្ទាប់",
                Last = "ចុងក្រោយ",
            };
            Aria = new Aria
            {
                SortAscending = ": ចុចដើម្បីរៀបជួរឈរនេះតាមលំដាប់ឡើង",
                SortDescending = ": ចុចដើម្បីរៀបជួរឈរនេះតាមលំដាប់ចុះ",
            };
        }
    }
}

