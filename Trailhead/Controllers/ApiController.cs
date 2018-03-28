using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Trailhead.Models;

namespace Trailhead.Controllers
{
    public class ApiController: Controller
    {
        public async Task<IActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://developer.nps.gov/");
                var response =
                    await client.GetAsync($"api/v1/parks?q=national%20park&fields=addresses&sort=fullName&api_key=hBmsOHpo5rbqEnPrPYpvhhTqd3ExLRgdfUQv0DJj");
                response.EnsureSuccessStatusCode();
                var stringresult = await response.Content.ReadAsStringAsync();
                JObject convert = JObject.Parse(stringresult);
                IList<JToken> results = convert["data"].Children().ToList();
                IList<NationalPark> natParks = new List<NationalPark>();
                foreach (JToken result in results)
                {
                    NationalPark natPark = result.ToObject<NationalPark>();
                    natParks.Add(natPark);
                }
                return View(natParks);

            }
            
        }
    }
}
