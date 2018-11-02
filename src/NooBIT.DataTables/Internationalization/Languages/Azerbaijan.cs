namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Azerbaijan : NamedLanguageSettings
    {
        internal Azerbaijan() : base("az-Latn")
        {
            EmptyTable = "Cədvəldə heç bir məlumat yoxdur";
            Info = $" {TOTAL} Nəticədən {START} - {END} Arası Nəticələr";
            InfoEmpty = "Nəticə Yoxdur";
            InfoFiltered = $"( {MAX} Nəticə İçindən Tapılanlar)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Səhifədə {MENU} Nəticə Göstər";
            LoadingRecords = "Yüklənir...";
            Processing = "Gözləyin...";
            Search = "Axtarış:";
            ZeroRecords = "Nəticə Tapılmadı.";
            Paginate = new Paginate
            {
                First = "İlk",
                Previous = "Öncəki",
                Next = "Sonraki",
                Last = "Axırıncı",
            };
            Aria = new Aria
            {
                SortAscending = ": sütunu artma sırası üzərə aktiv etmək",
                SortDescending = ": sütunu azalma sırası üzərə aktiv etmək",
            };
        }
    }
}

