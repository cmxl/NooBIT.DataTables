namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Filipino : NamedLanguageSettings
    {
        internal Filipino() : base("fil-Latn")
        {
            EmptyTable = null;
            Info = $"Ipinapakita ang  {START}  sa {END} ng {TOTAL} entries";
            InfoEmpty = "Ipinapakita ang 0-0 ng 0 entries";
            InfoFiltered = $"(na-filter mula {MAX} kabuuang entries)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Ipakita {MENU} entries";
            LoadingRecords = null;
            Processing = "Pagproseso...";
            Search = "Paghahanap:";
            ZeroRecords = "Walang katugmang  mga talaan  na natagpuan";
            Paginate = new Paginate
            {
                First = "Unang",
                Previous = "Nakaraan",
                Next = "Susunod",
                Last = "Huli",
            };
        }
    }
}

