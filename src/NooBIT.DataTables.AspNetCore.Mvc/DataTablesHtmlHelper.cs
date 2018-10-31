using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using NooBIT.DataTables.AspNetCore.Mvc.Renderers;
using NooBIT.DataTables.Language;

namespace NooBIT.DataTables.AspNetCore.Mvc
{
    public static class DataTablesHtmlHelper
    {
        private static readonly MvcHtmlDataTableRenderer TableRenderer = new MvcHtmlDataTableRenderer();
        private static readonly MvcHtmlDataTableColumnJsonRenderer ColumnRenderer = new MvcHtmlDataTableColumnJsonRenderer();

        public static IHtmlContent DataTableColumns<TEntity>(this IHtmlHelper<IDataTable<TEntity>> _, IEnumerable<DataTable<TEntity>.Column> columns) where TEntity : class
        {
            return ColumnRenderer.Render(columns);
        }

        public static IHtmlContent DataTable<TEntity>(this IHtmlHelper<IDataTable<TEntity>> _, IDataTable<TEntity> dataTable) where TEntity : class
        {
            return TableRenderer.Render(dataTable);
        }

        public static IHtmlContent Language(this IHtmlHelper _, LanguageSettings languageSettings)
        {
            return JsonRenderer.Render(languageSettings);
        }
    }
}