using Newtonsoft.Json;

namespace NooBIT.DataTables.Models
{
    public class AjaxOrder
    {
        [JsonProperty(PropertyName = "column")]
        public int Column { get; set; }

        [JsonProperty(PropertyName = "dir")]
        public string Dir { get; set; }
    }
}