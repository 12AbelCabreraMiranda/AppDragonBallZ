using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AppDragonBallZ.Model.DBZmodel
{
    public class Character
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ki")]
        public string Ki { get; set; }

        [JsonProperty("maxKi")]
        public string MaxKi { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("affiliation")]
        public string Affiliation { get; set; }

        [JsonProperty("deletedAt")]
        public object DeletedAt { get; set; }

        [JsonProperty("originPlanet")]
        public OriginPlanet OriginPlanet { get; set; }

        [JsonProperty("transformations")]
        public List<Transformation> Transformations { get; set; }
    }
}
