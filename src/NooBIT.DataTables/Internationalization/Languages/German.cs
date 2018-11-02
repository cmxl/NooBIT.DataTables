namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class German : NamedLanguageSettings
    {
        internal German() : base("de-de")
        {
            EmptyTable = "Keine Daten in der Tabelle vorhanden";
            Info = $"{START} bis {END} von {TOTAL} Einträgen";
            InfoEmpty = "Keine Daten vorhanden";
            InfoFiltered = $"(gefiltert von {MAX} Einträgen)";
            InfoPostFix = null;
            InfoThousands = ".";
            LengthMenu = $"{MENU} Einträge anzeigen";
            LoadingRecords = "Wird geladen ..";
            Processing = "Bitte warten ..";
            Search = "Suchen";
            ZeroRecords = "Keine Einträge vorhanden";

            Paginate = new Paginate
            {
                First = "Erste",
                Last = "Letzte",
                Next = "Nächste",
                Previous = "Zurück"
            };

            Aria = new Aria
            {
                SortAscending = ": aktivieren, um Spalte aufsteigend zu sortieren",
                SortDescending = ": aktivieren, um Spalte absteigend zu sortieren"
            };

            Select = new Select
            {
                Rows = new Rows
                {
                    Multiple = "%d Zeilen ausgewählt",
                    None = null,
                    Single = "1 Zeile ausgewählt"
                }
            };

            Buttons = new Buttons
            {
                Print = "Drucken",
                ColVis = "Spalten",
                Copy = "Kopieren",
                CopyTitle = "In Zwischenablage kopieren",
                CopyKeys = "Taste <i>ctrl</i> oder <i>\u2318</i> + <i>C</i> um Tabelle<br>in Zwischenspeicher zu kopieren.<br><br>Um abzubrechen die Nachricht anklicken oder Escape drücken.",
                CopySuccess = new CopySuccess
                {
                    Multiple = "%d Zeilen kopiert",
                    Single = "1 Zeile kopiert"
                }
            };
        }
    }
}
