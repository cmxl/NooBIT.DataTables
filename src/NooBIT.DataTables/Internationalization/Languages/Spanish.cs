namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Spanish : NamedLanguageSettings
    {
        internal Spanish() : base("es-ES")
        {
            EmptyTable = "Ningún dato disponible en esta tabla";
            Info = $"Mostrando registros del {START} al {END} de un total de {TOTAL} registros";
            InfoEmpty = "Mostrando registros del 0 al 0 de un total de 0 registros";
            InfoFiltered = $"(filtrado de un total de {MAX} registros)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Mostrar {MENU} registros";
            LoadingRecords = "Cargando...";
            Processing = "Procesando...";
            Search = "Buscar:";
            ZeroRecords = "No se encontraron resultados";
            Paginate = new Paginate
            {
                First = "Primero",
                Previous = "Anterior",
                Next = "Siguiente",
                Last = "Último",
            };
            Aria = new Aria
            {
                SortAscending = ": Activar para ordenar la columna de manera ascendente",
                SortDescending = ": Activar para ordenar la columna de manera descendente",
            };
        }
    }
}

