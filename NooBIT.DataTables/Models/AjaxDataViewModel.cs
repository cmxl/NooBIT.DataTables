using System.Collections.Generic;
using Newtonsoft.Json;

namespace NooBIT.DataTables.Models
{
    public class AjaxDataViewModel
    {
        [JsonProperty(PropertyName = "draw")]
        public int Draw { get; set; }

        [JsonProperty(PropertyName = "recordsTotal")]
        public long RecordsTotal { get; set; }

        [JsonProperty(PropertyName = "recordsFiltered")]
        public long RecordsFiltered { get; set; }

        [JsonProperty(PropertyName = "data")]
        public IList<dynamic> Data { get; set; } = new List<dynamic>();

        [JsonProperty(PropertyName = "error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }
    }
}