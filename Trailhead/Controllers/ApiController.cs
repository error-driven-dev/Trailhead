using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Trailhead.Models;
using Trailhead.Models.API;


//used to seed database
namespace Trailhead.Controllers
{
    public class ApiController: Controller
    {
        private IApiRepository _repository;

        public ApiController(IApiRepository repository)
        {
            _repository = repository;
        }

        public async Task Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://developer.nps.gov/");
                var response =
                    await client.GetAsync($"api/v1/parks?q=national%20park&fields=addresses&start=51&sort=fullName&api_key=hBmsOHpo5rbqEnPrPYpvhhTqd3ExLRgdfUQv0DJj");
                response.EnsureSuccessStatusCode();
                var stringresult = await response.Content.ReadAsStringAsync();
                JObject convert = JObject.Parse(stringresult);
                IList<JToken> results = convert["data"].Children().ToList();
                List<NationalPark> natParks = new List<NationalPark>();
                foreach (JToken result in results)
                {
                    var lat = "";
                    var lon = "";
                    var latlong = result["latLong"].ToString().Split(", ");
                    if (latlong[0].Length > 4 && latlong[1].Length > 5)
                    {
                        lat = latlong[0]?.Substring(4);
                        lon = latlong[1]?.Substring(5);
                    }
                    else
                    {
                        lat = "unknown";
                        lon = "unknown";
                    }


                    var nationalPark = new NationalPark()
                    {
                        FullName = (string) result["fullName"],
                        Lat = lat,
                        Lon = lon,
                        City = (string) result["addresses"][0]["city"],
                        State = (string) result["addresses"][0]["stateCode"]
                    };
                    natParks.Add(nationalPark);
          
                    

                };
                _repository.AddMultipleParks(natParks);

            }
                
                
            }
            
        }
    }

