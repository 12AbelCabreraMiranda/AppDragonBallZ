using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.Model.DBZmodel
{
    public class Links
    {
        [JsonProperty("first")]
        public Uri First { get; set; }

        [JsonProperty("previous")]
        public Uri Previous { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("last")]
        public Uri Last { get; set; }
    }
}
