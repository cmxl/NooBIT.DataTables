using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using NooBIT.DataTables.Internationalization.Languages;

namespace NooBIT.DataTables.Internationalization
{
    public static class Language
    {
        public static readonly Lazy<IReadOnlyDictionary<string, NamedLanguageSettings>> All = new(() =>
        {
            var languages = typeof(Language)
                .GetFields()
                .Where(field => field.FieldType == typeof(NamedLanguageSettings))
                .Select(field => (NamedLanguageSettings)field.GetValue(null))
                .ToDictionary(language => language.CultureInfo.Name, language => language, StringComparer.OrdinalIgnoreCase);

            return new ReadOnlyDictionary<string, NamedLanguageSettings>(languages);
        }, LazyThreadSafetyMode.PublicationOnly);

        public static readonly NamedLanguageSettings Afrikaans = new Afrikaans();
        public static readonly NamedLanguageSettings Albanian = new Albanian();
        public static readonly NamedLanguageSettings Amharic = new Amharic();
        public static readonly NamedLanguageSettings Arabic = new Arabic();
        public static readonly NamedLanguageSettings Armenian = new Armenian();
        public static readonly NamedLanguageSettings Azerbaijan = new Azerbaijan();
        public static readonly NamedLanguageSettings Bangla = new Bangla();
        public static readonly NamedLanguageSettings Basque = new Basque();
        public static readonly NamedLanguageSettings Belarusian = new Belarusian();
        public static readonly NamedLanguageSettings Bulgarian = new Bulgarian();
        public static readonly NamedLanguageSettings Catalan = new Catalan();
        public static readonly NamedLanguageSettings ChineseTraditional = new ChineseTraditional();
        public static readonly NamedLanguageSettings Chinese = new Chinese();
        public static readonly NamedLanguageSettings Croatian = new Croatian();
        public static readonly NamedLanguageSettings Czech = new Czech();
        public static readonly NamedLanguageSettings Danish = new Danish();
        public static readonly NamedLanguageSettings Dutch = new Dutch();
        public static readonly NamedLanguageSettings English = new English();
        public static readonly NamedLanguageSettings Estonian = new Estonian();
        public static readonly NamedLanguageSettings Filipino = new Filipino();
        public static readonly NamedLanguageSettings Finnish = new Finnish();
        public static readonly NamedLanguageSettings French = new French();
        public static readonly NamedLanguageSettings Galician = new Galician();
        public static readonly NamedLanguageSettings Georgian = new Georgian();
        public static readonly NamedLanguageSettings German = new German();
        public static readonly NamedLanguageSettings Greek = new Greek();
        public static readonly NamedLanguageSettings Gujarati = new Gujarati();
        public static readonly NamedLanguageSettings Hebrew = new Hebrew();
        public static readonly NamedLanguageSettings Hindi = new Hindi();
        public static readonly NamedLanguageSettings Hungarian = new Hungarian();
        public static readonly NamedLanguageSettings Icelandic = new Icelandic();
        public static readonly NamedLanguageSettings IndonesianAlternative = new IndonesianAlternative();
        public static readonly NamedLanguageSettings Indonesian = new Indonesian();
        public static readonly NamedLanguageSettings Irish = new Irish();
        public static readonly NamedLanguageSettings Italian = new Italian();
        public static readonly NamedLanguageSettings Japanese = new Japanese();
        public static readonly NamedLanguageSettings Kazakh = new Kazakh();
        public static readonly NamedLanguageSettings Khmer = new Khmer();
        public static readonly NamedLanguageSettings Korean = new Korean();
        public static readonly NamedLanguageSettings Kyrgyz = new Kyrgyz();
        public static readonly NamedLanguageSettings Latvian = new Latvian();
        public static readonly NamedLanguageSettings Lithuanian = new Lithuanian();
        public static readonly NamedLanguageSettings Macedonian = new Macedonian();
        public static readonly NamedLanguageSettings Malay = new Malay();
        public static readonly NamedLanguageSettings Mongolian = new Mongolian();
        public static readonly NamedLanguageSettings Nepali = new Nepali();
        public static readonly NamedLanguageSettings NorwegianBokmal = new NorwegianBokmal();
        public static readonly NamedLanguageSettings NorwegianNynorsk = new NorwegianNynorsk();
        public static readonly NamedLanguageSettings Pashto = new Pashto();
        public static readonly NamedLanguageSettings Persian = new Persian();
        public static readonly NamedLanguageSettings Polish = new Polish();
        public static readonly NamedLanguageSettings PortugueseBrasil = new PortugueseBrasil();
        public static readonly NamedLanguageSettings Portuguese = new Portuguese();
        public static readonly NamedLanguageSettings Romanian = new Romanian();
        public static readonly NamedLanguageSettings Russian = new Russian();
        public static readonly NamedLanguageSettings Serbian = new Serbian();
        public static readonly NamedLanguageSettings Sinhala = new Sinhala();
        public static readonly NamedLanguageSettings Slovak = new Slovak();
        public static readonly NamedLanguageSettings Slovenian = new Slovenian();
        public static readonly NamedLanguageSettings Spanish = new Spanish();
        public static readonly NamedLanguageSettings Swahili = new Swahili();
        public static readonly NamedLanguageSettings Swedish = new Swedish();
        public static readonly NamedLanguageSettings Tamil = new Tamil();
        public static readonly NamedLanguageSettings Thai = new Thai();
        public static readonly NamedLanguageSettings Turkish = new Turkish();
        public static readonly NamedLanguageSettings Ukrainian = new Ukrainian();
        public static readonly NamedLanguageSettings Urdu = new Urdu();
        public static readonly NamedLanguageSettings Uzbek = new Uzbek();
        public static readonly NamedLanguageSettings Vietnamese = new Vietnamese();
        public static readonly NamedLanguageSettings Welsh = new Welsh();
        public static readonly NamedLanguageSettings Telugu = new Telugu();
    }
}
