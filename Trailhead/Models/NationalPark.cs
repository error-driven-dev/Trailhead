using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Trailhead.Models
{
    public class NationalPark
    {
        public int NationalParkID { get; set; }
        public string FullName { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }


}
