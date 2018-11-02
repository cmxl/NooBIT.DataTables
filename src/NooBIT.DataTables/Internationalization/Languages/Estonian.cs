namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Estonian : NamedLanguageSettings
    {
        internal Estonian() : base("et")
        {
            EmptyTable = null;
            Info = $"Kuvatud: {TOTAL} kirjet ({START}-{END})";
            InfoEmpty = "Otsinguvasteid ei leitud";
            InfoFiltered = $" - filteeritud {MAX} kirje seast.";
            InfoPostFix = "K&otilde;ik kuvatud kirjed p&otilde;hinevad reaalsetel tulemustel.";
            InfoThousands = null;
            LengthMenu = $"N&auml;ita kirjeid {MENU} kaupa";
            LoadingRecords = null;
            Processing = "Palun oodake, koostan kuvamiseks nimekirja!";
            Search = "Otsi k&otilde;ikide tulemuste seast:";
            ZeroRecords = "Otsitavat vastet ei leitud.";
            Paginate = new Paginate
            {
                First = "Algus",
                Previous = "Eelmine",
                Next = "J&auml;rgmine",
                Last = "Viimane",
            };
        }
    }
}

