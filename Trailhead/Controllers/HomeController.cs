using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trailhead.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trailhead.Controllers
{
    public class HomeController : Controller
    {
        private INationalParkRepository _nationalParkRepository;

        public HomeController(INationalParkRepository nationalParkRepository)
        {
            _nationalParkRepository = nationalParkRepository;
        }

        public IActionResult Index()
        {
            
            return View(_nationalParkRepository.NationalParks.OrderBy(x=>x.State));
        }
    }
}
