namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class PortugueseBrasil : NamedLanguageSettings
    {
        internal PortugueseBrasil() : base("pt-BR")
        {
            EmptyTable = "Nenhum registro encontrado";
            Info = $"Mostrando de {START} até {END} de {TOTAL} registros";
            InfoEmpty = "Mostrando 0 até 0 de 0 registros";
            InfoFiltered = $"(Filtrados de {MAX} registros)";
            InfoPostFix = "";
            InfoThousands = ".";
            LengthMenu = $"{MENU} resultados por página";
            LoadingRecords = "Carregando...";
            Processing = "Processando...";
            Search = "Pesquisar";
            ZeroRecords = "Nenhum registro encontrado";
            Paginate = new Paginate
            {
                First = "Primeiro",
                Previous = "Anterior",
                Next = "Próximo",
                Last = "Último",
            };
            Aria = new Aria
            {
                SortAscending = ": Ordenar colunas de forma ascendente",
                SortDescending = ": Ordenar colunas de forma descendente",
            };
            Select = new Select
            {
                Rows = new Rows
                {
                    Multiple = "Selecionado %d linhas",
                    Single = "Selecionado 1 linha",
                    None = "Nenhuma linha selecionada",
                },
            };
        }
    }
}

