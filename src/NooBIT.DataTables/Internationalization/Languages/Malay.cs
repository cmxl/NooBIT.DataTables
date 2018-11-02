namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Malay : NamedLanguageSettings
    {
        internal Malay() : base("ml")
        {
            EmptyTable = "Tiada data";
            Info = $"Paparan dari {START} hingga {END} dari {TOTAL} rekod";
            InfoEmpty = "Paparan 0 hingga 0 dari 0 rekod";
            InfoFiltered = $"(Ditapis dari jumlah {MAX} rekod)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Papar {MENU} rekod";
            LoadingRecords = "Diproses...";
            Processing = "Sedang diproses...";
            Search = "Carian:";
            ZeroRecords = "Tiada padanan rekod yang dijumpai.";
            Paginate = new Paginate
            {
                First = "Pertama",
                Previous = "Sebelum",
                Next = "Kemudian",
                Last = "Akhir",
            };
            Aria = new Aria
            {
                SortAscending = ": diaktifkan kepada susunan lajur menaik",
                SortDescending = ": diaktifkan kepada susunan lajur menurun",
            };
        }
    }
}

