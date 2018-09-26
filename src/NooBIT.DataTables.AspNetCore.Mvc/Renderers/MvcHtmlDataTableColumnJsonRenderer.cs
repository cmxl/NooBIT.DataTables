using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;

namespace NooBIT.DataTables.AspNetCore.Mvc.Renderers
{
    internal class MvcHtmlDataTableColumnJsonRenderer
    {
        public IHtmlContent Render<TEntity>(IEnumerable<DataTable<TEntity>.Column> columns) where TEntity : class
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

            var json = JsonConvert.SerializeObject(columnDefs, Formatting.Indented);
            return new HtmlString(json);
        }
    }
}