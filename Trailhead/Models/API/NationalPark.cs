using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Trailhead.Models
{
    public class NationalPark
    {
        public int NationalParkID { get; set; }
        public string fullName { get; set; }
        public IEnumerable<JObject> Addresses { get; set; }
       
        public string LatLong { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
