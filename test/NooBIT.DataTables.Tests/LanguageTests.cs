using Xunit.Abstractions;

namespace NooBIT.DataTables.Tests
{
    public class LanguageTests
    {
        private readonly ITestOutputHelper _output;

        public LanguageTests(ITestOutputHelper output)
        {
            _output = output;
        }

        //[Fact]
        //public void Default_German_LanguageSettings_FromJson()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        // official DataTables repo
        //        var response = client.GetAsync("https://raw.githubusercontent.com/DataTables/Plugins/master/i18n/German.lang").Result;
        //        var json = response.Content.ReadAsStringAsync().Result;

        //        // replace unicode escaped characters with unicode character
        //        Regex rx = new Regex(@"\\[uU]([0-9A-F]{4})");
        //        json = rx.Replace(json, match => ((char)int.Parse(match.Value.Substring(2), NumberStyles.HexNumber)).ToString());
        //        var german = LanguageSettings.FromJson(json);

        //        // compare as json string with the same formatting
        //        var languageJson1 = JsonConvert.SerializeObject(german, Formatting.None);
        //        var languageJson2 = JsonConvert.SerializeObject(LanguageSettings.German, Formatting.None);

        //        Assert.Equal(languageJson1, languageJson2);
        //    }
        //}

        //[Fact]
        //public async Task Create_CSharp_Classes_From_Language_Files()
        //{
        //    // replacing unicode characters
        //    Regex sanitize = new Regex(@"\\[uU]([0-9A-F]{4})");

        //    using (var client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Add("User-Agent", "DataTables Tests App");
        //        // official DataTables repo
        //        var apiResponse = await client.GetAsync("https://api.github.com/repos/DataTables/Plugins/contents/i18n");
        //        var apiJson = await apiResponse.Content.ReadAsStringAsync();
        //        var content = JsonConvert.DeserializeObject<IEnumerable<GitHubContent>>(apiJson);

        //        foreach (var lang in content)
        //        {
        //            var response = await client.GetAsync(lang.DownloadUrl);
        //            var json = await response.Content.ReadAsStringAsync();
        //            json = sanitize.Replace(json, match => ((char)int.Parse(match.Value.Substring(2), NumberStyles.HexNumber)).ToString());
        //            var language = LanguageSettings.FromJson(json);

        //            var classString = CSharpClassStringCreator.CreateLanguage(lang.Name.Replace(".lang", string.Empty), language);
        //            _output.WriteLine(classString);
        //        }

        //    }
        //}
    }
}