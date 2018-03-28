using System.Collections.Generic;

namespace Trailhead.Models.API
{
    public interface IRepository
    {
        IEnumerable<NationalPark> NationalParks { get; }
        NationalPark this[int id] { get; }
        NationalPark AddPark(NationalPark park);

    }
}
