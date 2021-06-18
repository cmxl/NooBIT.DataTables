using System.Linq;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NooBIT.DataTables.AspNetCore.Mvc.Renderers
{
    internal class MvcHtmlDataTableRenderer
    {
        public static IHtmlContent Render<T>(IDataTable<T> dataTable) where T : class
        {
            var table = new TagBuilder("table");
            table.AddCssClass("compact");

            var thead = CreateTableHeader(dataTable);
            var tfoot = CreateTableFooter(dataTable);

            table.InnerHtml.AppendHtml(thead);
            if (tfoot != null)
                table.InnerHtml.AppendHtml(tfoot);

            return table;
        }

        private static IHtmlContent CreateTableFooter<T>(IDataTable<T> dataTable) where T : class
        {
            if (dataTable.Columns.All(x => x.Footer == null))
                return null;

            var tfoot = new TagBuilder("tfoot");
            tfoot.AddCssClass("editForm");

            var tr = new TagBuilder("tr");
            foreach (var column in dataTable.Columns.Where(x => x.Footer != null))
            {
                var td = new TagBuilder("td");
                if (column.Footer.ColSpan > 0)
                    td.Attributes.Add("colspan", column.Footer.ColSpan.ToString());

                td.InnerHtml.AppendHtml(RenderFooterEditor(column.Footer));
                tr.InnerHtml.AppendHtml(td);
            }

            tfoot.InnerHtml.AppendHtml(tr.ToString());
            return tfoot;
        }

        private static IHtmlContent CreateTableHeader<T>(IDataTable<T> dataTable) where T : class
        {
            var thead = new TagBuilder("thead");
            var tr = new TagBuilder("tr");
            var br = new TagBuilder("br");

            foreach (var column in dataTable.Columns)
            {
                var filter = CreateFilter(column);
                var display = CreateTableHeaderDisplay(column.Header);
                var th = new TagBuilder("th");
                th.InnerHtml.AppendHtml(display);
                th.InnerHtml.AppendHtml(br.RenderSelfClosingTag());
                th.InnerHtml.AppendHtml(filter);
                tr.InnerHtml.AppendHtml(th);
            }

            thead.InnerHtml.AppendHtml(tr);
            return thead;
        }

        private static IHtmlContent CreateTableHeaderDisplay(Header columnHeader)
        {
            var span = new TagBuilder("span");
            span.InnerHtml.Append(columnHeader.DisplayName);
            return span;
        }

        private static IHtmlContent RenderFooterEditor(Footer footer)
        {
            if (footer.Editor == null)
            {
                var span = new TagBuilder("span");
                span.AddCssClass("emphasize");
                span.InnerHtml.Append(footer.Text);
                return span;
            }

            return MvcHtmlEditorRenderer.Render(footer.Editor);
        }

        private static IHtmlContent CreateFilter<T>(DataTable<T>.Column column) where T : class => column.Header.Filter == null
                ? null
                : MvcHtmlEditorRenderer.Render(column.Header.Filter);
    }
}