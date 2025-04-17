using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDragonBallZ.Model.DBZmodel
{
    public class Pagination
    {      

        [JsonProperty("items")]
        public List<Character> Characters { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

    }
}
