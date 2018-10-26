using Newtonsoft.Json;

namespace NooBIT.DataTables.Models
{
    public class DataTableRequest
    {
        [JsonProperty(PropertyName = "draw")]
        public int Draw { get; set; }

        [JsonProperty(PropertyName = "columns")]
        public ColumnRequest[] Columns { get; set; }

        [JsonProperty(PropertyName = "order")]
        public OrderRequest[] Order { get; set; }

        [JsonProperty(PropertyName = "start")]
        public int Start { get; set; }

        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }

        [JsonProperty(PropertyName = "search")]
        public SearchRequest Search { get; set; }

        [JsonProperty(PropertyName = "_")]
        public long Timestamp { get; set; }


        public class ColumnRequest
        {
            [JsonProperty(PropertyName = "data")]
            public string Data { get; set; }

            [JsonProperty(PropertyName = "name")]
            public string Name { get; set; }

            [JsonProperty(PropertyName = "searchable")]
            public bool Searchable { get; set; }

            [JsonProperty(PropertyName = "orderable")]
            public bool Orderable { get; set; }

            [JsonProperty(PropertyName = "search")]
            public SearchRequest Search { get; set; }
        }

        public class OrderRequest
        {
            [JsonProperty(PropertyName = "column")]
            public int Column { get; set; }

            [JsonProperty(PropertyName = "dir")]
            public string Dir { get; set; }
        }

        public class SearchRequest
        {
            [JsonProperty(PropertyName = "value")]
            public string Value { get; set; }

            [JsonProperty(PropertyName = "regex")]
            public bool Regex { get; set; }
        }
    }
}