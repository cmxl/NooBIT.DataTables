namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Portuguese : NamedLanguageSettings
    {
        internal Portuguese() : base("pt-PT")
        {
            EmptyTable = "Não foi encontrado nenhum registo";
            Info = $"Mostrando de {START} até {END} de {TOTAL} registos";
            InfoEmpty = "Mostrando de 0 até 0 de 0 registos";
            InfoFiltered = $"(filtrado de {MAX} registos no total)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Mostrar {MENU} registos";
            LoadingRecords = null;
            Processing = "A carregar...";
            Search = "Procurar:";
            ZeroRecords = "Não foram encontrados resultados";
            Paginate = new Paginate
            {
                First = "Primeiro",
                Previous = "Anterior",
                Next = "Seguinte",
                Last = "Último",
            };
            Aria = new Aria
            {
                SortAscending = ": Ordenar colunas de forma ascendente",
                SortDescending = ": Ordenar colunas de forma descendente",
            };
        }
    }
}

