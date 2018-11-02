namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Arabic : NamedLanguageSettings
    {
        internal Arabic() : base("ar-sa")
        {
            EmptyTable = null;
            Info = $"إظهار {START} إلى {END} من أصل {TOTAL} مدخل";
            InfoEmpty = "يعرض 0 إلى 0 من أصل 0 سجل";
            InfoFiltered = $"(منتقاة من مجموع {MAX} مُدخل)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"أظهر {MENU} مدخلات";
            LoadingRecords = null;
            Processing = "جارٍ التحميل...";
            Search = "ابحث:";
            ZeroRecords = "لم يعثر على أية سجلات";
            Paginate = new Paginate
            {
                First = "الأول",
                Previous = "السابق",
                Next = "التالي",
                Last = "الأخير",
            };
        }
    }
}

