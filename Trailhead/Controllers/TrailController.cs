using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Trailhead.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Trailhead.Controllers
{
    public class TrailController : Controller
    {
      

        // GET: /<controller>/
        public async Task<IActionResult> Index()
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
        public async Task<IActionResult> One()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://trailapi-trailapi.p.mashape.com");
                client.DefaultRequestHeaders.Add("X-Mashape-Key", "K5jOkwvtBvmsh8TXTabBt7U9GG8Vp1PPeynjsnLhM43mHshsc7");
                var response =
                    await client.GetAsync(
                        $"/?unique_id=25214");
                response.EnsureSuccessStatusCode();
                var stringresult = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Place>(stringresult);

                return View("Index", data);
            }
        }
    }
}
