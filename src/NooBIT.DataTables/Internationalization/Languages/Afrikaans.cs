namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Afrikaans : NamedLanguageSettings
    {
        internal Afrikaans() : base("af")
        {
            EmptyTable = "Geen data beskikbaar in tabel";
            Info = $"uitstalling {START} to {END} of {TOTAL} inskrywings";
            InfoEmpty = "uitstalling 0 to 0 of 0 inskrywings";
            InfoFiltered = $"(gefiltreer uit {MAX} totaal inskrywings)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"uitstal {MENU} inskrywings";
            LoadingRecords = "laai...";
            Processing = "verwerking...";
            Search = "soektog:";
            ZeroRecords = "Geen treffers gevind";
            Paginate = new Paginate
            {
                First = "eerste",
                Previous = "vorige",
                Next = "volgende",
                Last = "laaste",
            };
            Aria = new Aria
            {
                SortAscending = ": aktiveer kolom stygende te sorteer",
                SortDescending = ": aktiveer kolom orde te sorteer",
            };
        }
    }
}

