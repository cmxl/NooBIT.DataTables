namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Galician : NamedLanguageSettings
    {
        internal Galician() : base("gl")
        {
            EmptyTable = "Ningún dato dispoñible nesta táboa";
            Info = $"Mostrando rexistros do {START} ao {END} dun total de {TOTAL} rexistros";
            InfoEmpty = "Mostrando rexistros do 0 ao 0 dun total de 0 rexistros";
            InfoFiltered = $"(filtrado dun total de {MAX} rexistros)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Mostrar {MENU} rexistros";
            LoadingRecords = "Cargando...";
            Processing = "Procesando...";
            Search = "Buscar:";
            ZeroRecords = "Non se atoparon resultados";
            Paginate = new Paginate
            {
                First = "Primeiro",
                Previous = "Anterior",
                Next = "Seguinte",
                Last = "Último",
            };
            Aria = new Aria
            {
                SortAscending = ": Activar para ordenar a columna de maneira ascendente",
                SortDescending = ": Activar para ordenar a columna de maneira descendente",
            };
        }
    }
}

