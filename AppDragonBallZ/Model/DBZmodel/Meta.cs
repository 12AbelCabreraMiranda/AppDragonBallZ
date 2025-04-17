using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.Model.DBZmodel
{
    public class Meta
    {
        [JsonProperty("totalItems")]
        public long TotalItems { get; set; }

        [JsonProperty("itemCount")]
        public long ItemCount { get; set; }

        [JsonProperty("itemsPerPage")]
        public long ItemsPerPage { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("currentPage")]
        public long CurrentPage { get; set; }
    }
}
