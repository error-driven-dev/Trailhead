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
        
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Location { get; set; }
        public string ImgSmallMed { get; set; }
        public decimal? Length { get; set; }
        public int Low { get; set; }
        public int Ascent { get; set; }
        public long Longitude { get; set; }
        public long Latitude { get; set; }
    }


 
}
