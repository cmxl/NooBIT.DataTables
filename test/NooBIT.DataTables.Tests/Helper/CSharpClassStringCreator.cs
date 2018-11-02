using System.Reflection;
using System.Text;
using NooBIT.DataTables.Internationalization;

namespace NooBIT.DataTables.Tests.Helper
{
    public static class CSharpClassStringCreator
    {
        public static string CreateLanguage(string className, LanguageSettings languageSettings)
        {
            var sb = new StringBuilder();

            sb.AppendLine("namespace NooBIT.DataTables.Language");
            sb.AppendLine("{");
            sb.AppendLine($"\tinternal class {className} : LanguageSettings");
            sb.AppendLine("\t{");
            sb.AppendLine($"\t\tinternal {className}()");
            sb.AppendLine("\t\t{");

            var properties = languageSettings.GetType().GetProperties();
            WriteProperties(sb, properties, languageSettings, null, "\t\t\t");

            sb.AppendLine("\t\t}"); // ctor
            sb.AppendLine("\t}"); // class
            sb.AppendLine("}"); // namespace
            return sb.ToString();
        }

        private static void WriteProperties(StringBuilder sb, PropertyInfo[] properties, LanguageSettings languageSettings, object property, string tabs)
        {
            var statementSeparator = property == null ? ";" : ",";
            foreach (var prop in properties)
            {
                if (prop.PropertyType == typeof(string))
                {

                    var value = (string)prop.GetValue(property ?? languageSettings);
                    if (value != null)
                    {
                        var dollarSymbol = string.Empty;
                        if (value.Contains(LanguageSettings.END)
                            || value.Contains(LanguageSettings.MAX)
                            || value.Contains(LanguageSettings.MENU)
                            || value.Contains(LanguageSettings.START)
                            || value.Contains(LanguageSettings.TOTAL))
                            dollarSymbol = "$";

                        value = value.Replace(LanguageSettings.END, $"{{{nameof(LanguageSettings.END)}}}");
                        value = value.Replace(LanguageSettings.MAX, $"{{{nameof(LanguageSettings.MAX)}}}");
                        value = value.Replace(LanguageSettings.MENU, $"{{{nameof(LanguageSettings.MENU)}}}");
                        value = value.Replace(LanguageSettings.START, $"{{{nameof(LanguageSettings.START)}}}");
                        value = value.Replace(LanguageSettings.TOTAL, $"{{{nameof(LanguageSettings.TOTAL)}}}");
                        sb.AppendLine($"{tabs}{prop.Name} = {dollarSymbol}\"{value}\"{statementSeparator}");
                    }
                    else
                    {
                        sb.AppendLine($"{tabs}{prop.Name} = null{statementSeparator}");
                    }
                }
                else
                {
                    var refType = prop.GetValue(property ?? languageSettings);

                    if (refType == null)
                        continue;

                    var props = refType.GetType().GetProperties();
                    sb.AppendLine($"{tabs}{prop.Name} = new {prop.Name}");
                    sb.AppendLine($"{tabs}{{");
                    WriteProperties(sb, props, languageSettings, refType, "\t\t\t\t");
                    sb.AppendLine($"{tabs}}}{statementSeparator}");
                }
            }
        }
    }
}
