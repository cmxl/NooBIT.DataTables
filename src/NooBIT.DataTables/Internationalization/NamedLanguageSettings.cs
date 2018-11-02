using System.Globalization;
using Newtonsoft.Json;

namespace NooBIT.DataTables.Internationalization
{
    public class NamedLanguageSettings : LanguageSettings
    {
        public NamedLanguageSettings(string culture)
        {
            CultureInfo = new CultureInfo(culture);
        }

        [JsonIgnore]
        public CultureInfo CultureInfo { get; private set; }
    }
}
