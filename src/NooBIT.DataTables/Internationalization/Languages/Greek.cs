namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Greek : NamedLanguageSettings
    {
        internal Greek() : base("el")
        {
            EmptyTable = "Δεν υπάρχουν δεδομένα στον πίνακα";
            Info = $"Εμφανίζονται {START} έως {END} από {TOTAL} εγγραφές";
            InfoEmpty = "Εμφανίζονται 0 έως 0 από 0 εγγραφές";
            InfoFiltered = $"(φιλτραρισμένες από {MAX} συνολικά εγγραφές)";
            InfoPostFix = "";
            InfoThousands = ".";
            LengthMenu = $"Δείξε {MENU} εγγραφές";
            LoadingRecords = "Φόρτωση...";
            Processing = "Επεξεργασία...";
            Search = "Αναζήτηση:";
            ZeroRecords = "Δεν βρέθηκαν εγγραφές που να ταιριάζουν";
            Paginate = new Paginate
            {
                First = "Πρώτη",
                Previous = "Προηγούμενη",
                Next = "Επόμενη",
                Last = "Τελευταία",
            };
            Aria = new Aria
            {
                SortAscending = ": ενεργοποιήστε για αύξουσα ταξινόμηση της στήλης",
                SortDescending = ": ενεργοποιήστε για φθίνουσα ταξινόμηση της στήλης",
            };
        }
    }
}

