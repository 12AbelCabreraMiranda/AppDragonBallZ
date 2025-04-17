using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.Model.DBZmodel
{
    public class Transformation
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("ki")]
        public string Ki { get; set; }

        [JsonProperty("deletedAt")]
        public object DeletedAt { get; set; }
    }
}
