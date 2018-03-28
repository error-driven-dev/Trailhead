using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Trailhead.Models
{
  
    public class Trail
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        
    }

    public class Jtrail
    {
        public IEnumerable<JObject> jtrail { get; set; }
    }
}
