namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Urdu : NamedLanguageSettings
    {
        internal Urdu() : base("ur")
        {
            EmptyTable = null;
            Info = $"فہرست کي تک {END} سے {START} سے ميں {TOTAL} فہرست پوري ہے نظر پيش";
            InfoEmpty = "فہرست کي تک 0 سے 0 سے ميں 0 قل ہے نظر پيشّ";
            InfoFiltered = $"(فہرست ہوئ چھني سے ميں {MAX} قل)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"دکہائين شقيں کي ({MENU}) فہرست";
            LoadingRecords = null;
            Processing = "ہے جاري عملدرامد...";
            Search = "کرو تلاش:";
            ZeroRecords = "ملے نہيں مفروضات جلتے ملتے کوئ";
            Paginate = new Paginate
            {
                First = "پہلا",
                Previous = "پچہلا",
                Next = "اگلا",
                Last = "آخري",
            };
        }
    }
}

