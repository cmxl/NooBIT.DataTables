namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Irish : NamedLanguageSettings
    {
        internal Irish() : base("ga")
        {
            EmptyTable = null;
            Info = $"{START} Showing a {END} na n-iontrálacha  {TOTAL}";
            InfoEmpty = "Showing 0-0 na n-iontrálacha  0";
            InfoFiltered = $"(scagtha ó {MAX} iontrálacha iomlán)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Taispeáin iontrálacha {MENU}";
            LoadingRecords = null;
            Processing = "Próiseáil...";
            Search = "Cuardaigh:";
            ZeroRecords = "Gan aon taifead meaitseáil aimsithe";
            Paginate = new Paginate
            {
                First = "An Chéad",
                Previous = "Roimhe Seo",
                Next = "Ar Aghaidh",
                Last = "Last",
            };
        }
    }
}

