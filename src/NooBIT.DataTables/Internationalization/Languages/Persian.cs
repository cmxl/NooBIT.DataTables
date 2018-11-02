namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Persian : NamedLanguageSettings
    {
        internal Persian() : base("fa")
        {
            EmptyTable = "هیچ داده ای در جدول وجود ندارد";
            Info = $"نمایش {START} تا {END} از {TOTAL} رکورد";
            InfoEmpty = "نمایش 0 تا 0 از 0 رکورد";
            InfoFiltered = $"(فیلتر شده از {MAX} رکورد)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"نمایش {MENU} رکورد";
            LoadingRecords = "در حال بارگزاری...";
            Processing = "در حال پردازش...";
            Search = "جستجو:";
            ZeroRecords = "رکوردی با این مشخصات پیدا نشد";
            Paginate = new Paginate
            {
                First = "ابتدا",
                Previous = "قبلی",
                Next = "بعدی",
                Last = "انتها",
            };
            Aria = new Aria
            {
                SortAscending = ": فعال سازی نمایش به صورت صعودی",
                SortDescending = ": فعال سازی نمایش به صورت نزولی",
            };
        }
    }
}

