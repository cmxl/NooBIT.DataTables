namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class French : NamedLanguageSettings
    {
        internal French() : base("fr-FR")
        {
            EmptyTable = "Aucune donn&eacute;e disponible dans le tableau";
            Info = $"Affichage de l'&eacute;l&eacute;ment {START} &agrave; {END} sur {TOTAL} &eacute;l&eacute;ments";
            InfoEmpty = "Affichage de l'&eacute;l&eacute;ment 0 &agrave; 0 sur 0 &eacute;l&eacute;ment";
            InfoFiltered = $"(filtr&eacute; de {MAX} &eacute;l&eacute;ments au total)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Afficher {MENU} &eacute;l&eacute;ments";
            LoadingRecords = "Chargement en cours...";
            Processing = "Traitement en cours...";
            Search = "Rechercher&nbsp;:";
            ZeroRecords = "Aucun &eacute;l&eacute;ment &agrave; afficher";
            Paginate = new Paginate
            {
                First = "Premier",
                Previous = "Pr&eacute;c&eacute;dent",
                Next = "Suivant",
                Last = "Dernier",
            };
            Aria = new Aria
            {
                SortAscending = ": activer pour trier la colonne par ordre croissant",
                SortDescending = ": activer pour trier la colonne par ordre d&eacute;croissant",
            };
            Select = new Select
            {
                Rows = new Rows
                {
                    Multiple = "%d lignes s&eacute;lectionn&eacute;es",
                    Single = "1 ligne s&eacute;lectionn&eacute;e",
                    None = "Aucune ligne s&eacute;lectionn&eacute;e",
                },
            };
        }
    }
}

