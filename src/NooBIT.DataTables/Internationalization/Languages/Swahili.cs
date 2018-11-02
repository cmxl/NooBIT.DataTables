namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Swahili : NamedLanguageSettings
    {
        internal Swahili() : base("sw")
        {
            EmptyTable = "Hakuna data iliyo patikana";
            Info = $"Inaonyesha {START} mpaka {END} ya matokeo {TOTAL}";
            InfoEmpty = "Inaonyesha 0 hadi 0 ya matokeo 0";
            InfoFiltered = $"(uschujo kutoka matokeo idadi {MAX})";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Onyesha {MENU} matokeo";
            LoadingRecords = "Inapakia...";
            Processing = "Processing...";
            Search = "Tafuta:";
            ZeroRecords = "Rekodi vinavyolingana haziku patikana";
            Paginate = new Paginate
            {
                First = "Mwanzo",
                Previous = "Kabla",
                Next = "Ijayo",
                Last = "Mwisho",
            };
            Aria = new Aria
            {
                SortAscending = ": seti kulainisha sanjari kwa mtindo wa upandaji",
                SortDescending = ": seti kulainisha sanjari kwa mtindo wa mteremko",
            };
        }
    }
}

