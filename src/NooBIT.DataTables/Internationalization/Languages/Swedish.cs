namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Swedish : NamedLanguageSettings
    {
        internal Swedish() : base("sv")
        {
            EmptyTable = "Tabellen innehåller ingen data";
            Info = $"Visar {START} till {END} av totalt {TOTAL} rader";
            InfoEmpty = "Visar 0 till 0 av totalt 0 rader";
            InfoFiltered = $"(filtrerade från totalt {MAX} rader)";
            InfoPostFix = "";
            InfoThousands = " ";
            LengthMenu = $"Visa {MENU} rader";
            LoadingRecords = "Laddar...";
            Processing = "Bearbetar...";
            Search = "Sök:";
            ZeroRecords = "Hittade inga matchande resultat";
            Paginate = new Paginate
            {
                First = "Första",
                Previous = "Föregående",
                Next = "Nästa",
                Last = "Sista",
            };
            Aria = new Aria
            {
                SortAscending = ": aktivera för att sortera kolumnen i stigande ordning",
                SortDescending = ": aktivera för att sortera kolumnen i fallande ordning",
            };
        }
    }
}

