using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;

namespace NooBIT.DataTables.AspNetCore.Mvc.Renderers
{
    internal static class JsonRenderer
    {
        public static IHtmlContent Render(object obj)
        {
            var json = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            return new HtmlString(json);
        }
    }
}