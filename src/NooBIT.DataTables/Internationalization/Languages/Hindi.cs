namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Hindi : NamedLanguageSettings
    {
        internal Hindi() : base("hi")
        {
            EmptyTable = null;
            Info = $"{START} to {END} of {TOTAL} प्रविष्टियां दिखा रहे हैं";
            InfoEmpty = "0 में से 0 से 0 प्रविष्टियां दिखा रहे हैं";
            InfoFiltered = $"({MAX} कुल प्रविष्टियों में से छठा हुआ)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $" {MENU} प्रविष्टियां दिखाएं ";
            LoadingRecords = null;
            Processing = "प्रगति पे हैं ...";
            Search = "खोजें:";
            ZeroRecords = "रिकॉर्ड्स का मेल नहीं मिला";
            Paginate = new Paginate
            {
                First = "प्रथम",
                Previous = "पिछला",
                Next = "अगला",
                Last = "अंतिम",
            };
        }
    }
}

