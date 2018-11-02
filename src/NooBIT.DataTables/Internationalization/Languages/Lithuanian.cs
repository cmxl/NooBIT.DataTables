namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Lithuanian : NamedLanguageSettings
    {
        internal Lithuanian() : base("lt")
        {
            EmptyTable = "Lentelėje nėra duomenų";
            Info = $"Rodomi įrašai nuo {START} iki {END} iš {TOTAL} įrašų";
            InfoEmpty = "Rodomi įrašai nuo 0 iki 0 iš 0";
            InfoFiltered = $"(atrinkta iš {MAX} įrašų)";
            InfoPostFix = "";
            InfoThousands = " ";
            LengthMenu = $"Rodyti {MENU} įrašus";
            LoadingRecords = "Įkeliama...";
            Processing = "Apdorojama...";
            Search = "Ieškoti:";
            ZeroRecords = "Įrašų nerasta";
            Paginate = new Paginate
            {
                First = "Pirmas",
                Previous = "Ankstesnis",
                Next = "Tolimesnis",
                Last = "Paskutinis",
            };
        }
    }
}

