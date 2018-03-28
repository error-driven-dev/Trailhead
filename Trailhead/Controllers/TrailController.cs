using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Trailhead.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trailhead.Controllers
{
    public class TrailController : Controller
    {
      

        // GET: /<controller>/
        public async Task<IActionResult> Index2()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://trailapi-trailapi.p.mashape.com");
                client.DefaultRequestHeaders.Add("X-Mashape-Key", "K5jOkwvtBvmsh8TXTabBt7U9GG8Vp1PPeynjsnLhM43mHshsc7");
                var response =
                    await client.GetAsync(
                        $"/?limit=25&q[activities_activity_type_name_eq]=hiking&q[state_cont]=washington&radius=25");
                response.EnsureSuccessStatusCode();
                var stringresult = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Place>(stringresult);

                return View(data);
            }
        }
        public async Task<IActionResult> Index(string coord)
        {
            var badstring = coord.Split(' ');
            var goodstring = badstring.Join("");
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://www.hikingproject.com");
                var response =
                    await client.GetAsync($"/data/get-trails?{goodstring}&maxDistance=200&key=200238177-24a146be40fa02014108db565b54b2ed");
                response.EnsureSuccessStatusCode();
                var stringresult = await response.Content.ReadAsStringAsync();
                JObject result = JObject.Parse(stringresult);

                return View(result);
            }
        }

        public IActionResult ShowTrail(Jtrail trail)
        {
   
            
            return View(trail);
        }

    }
}
