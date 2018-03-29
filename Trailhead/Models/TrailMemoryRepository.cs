using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch.Internal;

namespace Trailhead.Models
{
    public class TrailMemoryRepository: ITrailRepository
    {
        private List<Trail> _trails = new List<Trail>();

        public IEnumerable<Trail> Trails { get; set; }

        public List<Trail> AddTrails(List<Trail> apiTrails)
        {
            _trails.Clear();
            _trails.AddRange(apiTrails);
            return _trails;
        }

        public Trail GetTrail(int id)
        {
            var trailDetails = _trails.FirstOrDefault(t => t.Id == id);
            return trailDetails;
        }
    }

    public interface ITrailRepository
    {
        IEnumerable<Trail> Trails { get; set; }

        List<Trail> AddTrails(List<Trail> trailList);
        Trail GetTrail(int id);

    }
}
