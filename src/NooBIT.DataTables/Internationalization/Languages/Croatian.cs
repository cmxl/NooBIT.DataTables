namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Croatian : NamedLanguageSettings
    {
        internal Croatian() : base("hr")
        {
            EmptyTable = "Nema podataka u tablici";
            Info = $"Prikazano {START} do {END} od {TOTAL} rezultata";
            InfoEmpty = "Prikazano 0 do 0 od 0 rezultata";
            InfoFiltered = $"(filtrirano iz {MAX} ukupnih rezultata)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Prikaži {MENU} rezultata po stranici";
            LoadingRecords = "Dohvaćam...";
            Processing = "Obrađujem...";
            Search = "Pretraži:";
            ZeroRecords = "Ništa nije pronađeno";
            Paginate = new Paginate
            {
                First = "Prva",
                Previous = "Nazad",
                Next = "Naprijed",
                Last = "Zadnja",
            };
            Aria = new Aria
            {
                SortAscending = ": aktiviraj za rastući poredak",
                SortDescending = ": aktiviraj za padajući poredak",
            };
        }
    }
}

