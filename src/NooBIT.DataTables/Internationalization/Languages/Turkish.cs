namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Turkish : NamedLanguageSettings
    {
        internal Turkish() : base("tr")
        {
            EmptyTable = "Tabloda herhangi bir veri mevcut değil";
            Info = $"{TOTAL} kayıttan {START} - {END} arasındaki kayıtlar gösteriliyor";
            InfoEmpty = "Kayıt yok";
            InfoFiltered = $"({MAX} kayıt içerisinden bulunan)";
            InfoPostFix = "";
            InfoThousands = ".";
            LengthMenu = $"Sayfada {MENU} kayıt göster";
            LoadingRecords = "Yükleniyor...";
            Processing = "İşleniyor...";
            Search = "Ara:";
            ZeroRecords = "Eşleşen kayıt bulunamadı";
            Paginate = new Paginate
            {
                First = "İlk",
                Previous = "Önceki",
                Next = "Sonraki",
                Last = "Son",
            };
            Aria = new Aria
            {
                SortAscending = ": artan sütun sıralamasını aktifleştir",
                SortDescending = ": azalan sütun sıralamasını aktifleştir",
            };
            Select = new Select
            {
                Rows = new Rows
                {
                    Multiple = "%d kayıt seçildi",
                    Single = "1 kayıt seçildi",
                    None = "",
                },
            };
        }
    }
}

