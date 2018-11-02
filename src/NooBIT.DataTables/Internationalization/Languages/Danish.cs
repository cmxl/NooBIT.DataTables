namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Danish : NamedLanguageSettings
    {
        internal Danish() : base("da")
        {
            EmptyTable = null;
            Info = $"Viser {START} til {END} af {TOTAL} linjer";
            InfoEmpty = "Viser 0 til 0 af 0 linjer";
            InfoFiltered = $"(filtreret fra {MAX} linjer)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Vis {MENU} linjer";
            LoadingRecords = null;
            Processing = "Henter...";
            Search = "S&oslash;g:";
            ZeroRecords = "Ingen linjer matcher s&oslash;gningen";
            Paginate = new Paginate
            {
                First = "F&oslash;rste",
                Previous = "Forrige",
                Next = "N&aelig;ste",
                Last = "Sidste",
            };
        }
    }
}

