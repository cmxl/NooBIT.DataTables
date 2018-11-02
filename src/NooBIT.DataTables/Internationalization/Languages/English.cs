namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class English : NamedLanguageSettings
    {
        internal English() : base("en-US")
        {
            EmptyTable = "No data available in table";
            Info = $"Showing {START} to {END} of {TOTAL} entries";
            InfoEmpty = "Showing 0 to 0 of 0 entries";
            InfoFiltered = $"(filtered from {MAX} total entries)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Show {MENU} entries";
            LoadingRecords = "Loading...";
            Processing = "Processing...";
            Search = "Search:";
            ZeroRecords = "No matching records found";
            Paginate = new Paginate
            {
                First = "First",
                Previous = "Previous",
                Next = "Next",
                Last = "Last",
            };
            Aria = new Aria
            {
                SortAscending = ": activate to sort column ascending",
                SortDescending = ": activate to sort column descending",
            };
        }
    }
}

