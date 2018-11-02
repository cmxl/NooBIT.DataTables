namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Albanian : NamedLanguageSettings
    {
        internal Albanian() : base("sq")
        {
            EmptyTable = "Nuk ka asnjë të dhënë në tabele";
            Info = $"Duke treguar {START} deri {END} prej {TOTAL} reshtave";
            InfoEmpty = "Duke treguar 0 deri 0 prej 0 reshtave";
            InfoFiltered = $"(të filtruara nga gjithësej {MAX}  reshtave)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Shiko {MENU} reshta";
            LoadingRecords = "Duke punuar...";
            Processing = "Duke procesuar...";
            Search = "Kërkoni:";
            ZeroRecords = "Asnjë e dhënë nuk u gjet";
            Paginate = new Paginate
            {
                First = "E para",
                Previous = "E Kaluara",
                Next = "Tjetra",
                Last = "E Fundit",
            };
            Aria = new Aria
            {
                SortAscending = ": aktivizo për të sortuar kolumnin me vlera në ngritje",
                SortDescending = ": aktivizo për të sortuar kolumnin me vlera në zbritje",
            };
        }
    }
}

