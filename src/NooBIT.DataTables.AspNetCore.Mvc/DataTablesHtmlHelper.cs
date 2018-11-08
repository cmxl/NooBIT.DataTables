using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using NooBIT.DataTables.AspNetCore.Mvc.Renderers;
using NooBIT.DataTables.Internationalization;

namespace NooBIT.DataTables.AspNetCore.Mvc
{
    public static class DataTablesHtmlHelper
    {
        private static readonly MvcHtmlDataTableRenderer TableRenderer = new MvcHtmlDataTableRenderer();
        private static readonly MvcHtmlDataTableColumnJsonRenderer ColumnRenderer = new MvcHtmlDataTableColumnJsonRenderer();

        public static IHtmlContent DataTableColumns<T>(this IHtmlHelper _, IEnumerable<DataTable<T>.Column> columns) where T : class
        {
            return ColumnRenderer.Render(columns);
        }

        public static IHtmlContent DataTable<T>(this IHtmlHelper _, IDataTable<T> dataTable) where T : class
        {
            return TableRenderer.Render(dataTable);
        }

        public static IHtmlContent Language(this IHtmlHelper _, LanguageSettings languageSettings)
        {
            return JsonRenderer.Render(languageSettings);
        }
    }
}