namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Catalan : NamedLanguageSettings
    {
        internal Catalan() : base("ca")
        {
            EmptyTable = null;
            Info = $"Mostrant de {START} a {END} de {TOTAL} registres";
            InfoEmpty = "Mostrant de 0 a 0 de 0 registres";
            InfoFiltered = $"(filtrat de {MAX} total registres)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Mostra {MENU} registres";
            LoadingRecords = null;
            Processing = "Processant...";
            Search = "Filtrar:";
            ZeroRecords = "No s'han trobat registres.";
            Paginate = new Paginate
            {
                First = "Primer",
                Previous = "Anterior",
                Next = "Següent",
                Last = "Últim",
            };
        }
    }
}

