using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

//here we grab the json file from the api that we are calling.
namespace OpenWeatherMapAPITesting.Weather_API_Services.Data_Handling
{
    class WeatherLatestDTO
    {
        public LatestWeatherRoot latestWeatherRoot { get; set; }
        public void DeserializeLatestWeather(string LatestsRateResponce)
        {
            latestWeatherRoot = JsonConvert.DeserializeObject<LatestWeatherRoot>(LatestsRateResponce);
        }
    }
}
