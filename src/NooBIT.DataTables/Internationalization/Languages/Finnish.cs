namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Finnish : NamedLanguageSettings
    {
        internal Finnish() : base("fi")
        {
            EmptyTable = "Ei näytettäviä tuloksia.";
            Info = $"Näytetään rivit {START} - {END} (yhteensä {TOTAL} )";
            InfoEmpty = "Näytetään 0 - 0 (yhteensä 0)";
            InfoFiltered = $"(suodatettu {MAX} tuloksen joukosta)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Näytä kerralla {MENU} riviä";
            LoadingRecords = "Ladataan...";
            Processing = "Hetkinen...";
            Search = "Etsi:";
            ZeroRecords = "Tietoja ei löytynyt";
            Paginate = new Paginate
            {
                First = "Ensimmäinen",
                Previous = "Edellinen",
                Next = "Seuraava",
                Last = "Viimeinen",
            };
            Aria = new Aria
            {
                SortAscending = ": lajittele sarake nousevasti",
                SortDescending = ": lajittele sarake laskevasti",
            };
            Select = new Select
            {
                Rows = new Rows
                {
                    Multiple = "Valittuna %d riviä",
                    Single = "Valittuna vain yksi rivi",
                    None = "Klikkaa riviä valitaksesi sen",
                },
            };
            Buttons = new Buttons
            {
                Print = null,
                ColVis = null,
                Copy = "Kopioi",
                CopyTitle = "Kopioi leikepöydälle",
                CopyKeys = "Paina <i>ctrl</i> tai <i>⌘</i> + <i>C</i> kopioidaksesi taulukon arvot<br> leikepöydälle. <br><br>Peruuttaaksesi klikkaa tähän tai Esc.",
                CopySuccess = new CopySuccess
                {
                    Multiple = "%d riviä kopioitu leikepöydälle",
                    Single = "Yksi rivi kopioitu leikepöydälle",
                },
            };
        }
    }
}

