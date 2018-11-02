namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Nepali : NamedLanguageSettings
    {
        internal Nepali() : base("ne")
        {
            EmptyTable = "टेबलमा डाटा उपलब्ध भएन";
            Info = $"{TOTAL} रेकर्ड मध्य {START} देखि {END} रेकर्ड देखाउंदै";
            InfoEmpty = "0 मध्य 0 देखि 0 रेकर्ड देखाउंदै";
            InfoFiltered = $"({MAX} कुल रेकर्डबाट छनौट गरिएको)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $" {MENU} रेकर्ड देखाउने ";
            LoadingRecords = "लोड हुँदैछ...";
            Processing = "प्रगति हुदैंछ ...";
            Search = "खोजी:";
            ZeroRecords = "कुनै मिल्ने रेकर्ड फेला परेन";
            Paginate = new Paginate
            {
                First = "प्रथम",
                Previous = "पछिल्लो",
                Next = "अघिल्लो",
                Last = "अन्तिम",
            };
            Aria = new Aria
            {
                SortAscending = ": अगाडिबाट अक्षरात्मक रूपमा क्रमबद्ध गराउने",
                SortDescending = ": पछाडिबाट अक्षरात्मक रूपमा क्रमबद्ध गराउने",
            };
        }
    }
}

