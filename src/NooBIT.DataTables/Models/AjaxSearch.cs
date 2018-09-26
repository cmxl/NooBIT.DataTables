using Newtonsoft.Json;

namespace NooBIT.DataTables.Models
{
    public class AjaxSearch
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "regex")]
        public bool Regex { get; set; }
    }
}