using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Trailhead.Models
{
    [JsonObject]
    public class Trail
    {
        public string City { get; set; }
        public string Name { get; set; }
        
    }

    public class Place
    {
        public IEnumerable<JObject> Places { get; set; }
    }
}
