using System.Globalization;
using System.Net.Http;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using NooBIT.DataTables.Language;
using Xunit;

namespace NooBIT.DataTables.Tests
{
    public class LanguageTests
    {
        [Fact]
        public void Default_German_LanguageSettings_FromJson()
        {
            using (var client = new HttpClient())
            {
                // official DataTables repo
                var response = client.GetAsync("https://raw.githubusercontent.com/DataTables/Plugins/master/i18n/German.lang").Result;
                var json = response.Content.ReadAsStringAsync().Result;

                // replace unicode escaped characters with unicode character
                Regex rx = new Regex(@"\\[uU]([0-9A-F]{4})");
                json = rx.Replace(json, match => ((char)int.Parse(match.Value.Substring(2), NumberStyles.HexNumber)).ToString());
                var german = LanguageSettings.FromJson(json);

                // compare as json string with the same formatting
                var languageJson1 = JsonConvert.SerializeObject(german, Formatting.None);
                var languageJson2 = JsonConvert.SerializeObject(LanguageSettings.German, Formatting.None);

                Assert.Equal(languageJson1, languageJson2);
            }
        }
    }
}
