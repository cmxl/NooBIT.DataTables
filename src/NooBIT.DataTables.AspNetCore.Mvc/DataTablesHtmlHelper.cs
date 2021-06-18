using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using NooBIT.DataTables.AspNetCore.Mvc.Renderers;
using NooBIT.DataTables.Internationalization;

namespace NooBIT.DataTables.AspNetCore.Mvc
{
    public static class DataTablesHtmlHelper
    {
        public static IHtmlContent DataTableColumns<T>(this IHtmlHelper _, IEnumerable<DataTable<T>.Column> columns) where T : class
        {
            return MvcHtmlDataTableColumnJsonRenderer.Render(columns);
        }

        public static IHtmlContent DataTable<T>(this IHtmlHelper _, IDataTable<T> dataTable) where T : class
        {
            return MvcHtmlDataTableRenderer.Render(dataTable);
        }

        public static IHtmlContent Language(this IHtmlHelper _, LanguageSettings languageSettings)
        {
            return JsonRenderer.Render(languageSettings);
        }
    }
}