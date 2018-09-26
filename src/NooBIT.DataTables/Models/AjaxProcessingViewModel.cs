using Newtonsoft.Json;

namespace NooBIT.DataTables.Models
{
    public class AjaxProcessingViewModel
    {
        [JsonProperty(PropertyName = "draw")]
        public int Draw { get; set; }

        [JsonProperty(PropertyName = "columns")]
        public AjaxColumn[] Columns { get; set; }

        [JsonProperty(PropertyName = "order")]
        public AjaxOrder[] Order { get; set; }

        [JsonProperty(PropertyName = "start")]
        public int Start { get; set; }

        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }

        [JsonProperty(PropertyName = "search")]
        public AjaxSearch Search { get; set; }

        [JsonProperty(PropertyName = "_")]
        public long Timestamp { get; set; }
    }
}