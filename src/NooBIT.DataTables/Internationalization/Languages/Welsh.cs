namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Welsh : NamedLanguageSettings
    {
        internal Welsh() : base("cy")
        {
            EmptyTable = "Dim data ar gael yn y tabl";
            Info = $"Dangos {START} i {END} o {TOTAL} cofnod";
            InfoEmpty = "Dangos 0 i 0 o 0 cofnod";
            InfoFiltered = $"(wedi hidlo o gyfanswm o {MAX} cofnod)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Dangos {MENU} cofnod";
            LoadingRecords = "Wrthi'n llwytho...";
            Processing = "Wrthi'n prosesu...";
            Search = "Chwilio:";
            ZeroRecords = "Heb ddod o hyd i gofnodion sy'n cyfateb";
            Paginate = new Paginate
            {
                First = "Cyntaf",
                Previous = "Blaenorol",
                Next = "Nesaf",
                Last = "Olaf",
            };
            Aria = new Aria
            {
                SortAscending = ": rhoi ar waith i drefnu colofnau o'r lleiaf i'r mwyaf",
                SortDescending = ": rhoi ar waith i drefnu colofnau o'r mwyaf i'r lleiaf",
            };
        }
    }
}

