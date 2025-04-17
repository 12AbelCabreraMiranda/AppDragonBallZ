using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.Model.DBZmodel
{
    public class OriginPlanet
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isDestroyed")]
        public bool IsDestroyed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("deletedAt")]
        public object DeletedAt { get; set; }
    }
}
