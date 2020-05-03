using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        
        [Route("temprature/{id}")]
        [HttpGet]
        public ActionResult<int> GetTempratureInFahrenheit(int cityId)
        {
            var rndNext = new System.Random();

            int temp = rndNext.Next(50, 150);

            return temp;
        }

        [Route("forecast/{id}")]
        [HttpGet]
        public ActionResult<string> GetWeatherForecast(int cityId)
        {
            string[] forecasts = { "Sunny", "Rainy", "Cool", "Breezy" };
            var rndNext = new System.Random();

            int idx = rndNext.Next(4);

            return forecasts[idx];
        }
    }
}
