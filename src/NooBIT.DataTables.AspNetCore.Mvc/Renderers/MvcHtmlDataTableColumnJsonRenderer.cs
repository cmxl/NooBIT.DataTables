using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Html;

namespace NooBIT.DataTables.AspNetCore.Mvc.Renderers
{
    internal class MvcHtmlDataTableColumnJsonRenderer
    {
        public static IHtmlContent Render<T>(IEnumerable<DataTable<T>.Column> columns) where T : class
        {
            var columnDefs = new List<dynamic>(columns.Select(x => new
            {
                name = x.Name,
                data = x.Name,
                targets = x.Target,
                visible = !x.Hidden,
                searchable = x.Searchable,
                orderable = x.Orderable
            }))
            {
                new
                {
                    defaultContent = "-",
                    targets = "_all"
                }
            };

            return JsonRenderer.Render(columnDefs);
        }
    }
}