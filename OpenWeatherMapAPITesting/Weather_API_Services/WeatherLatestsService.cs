using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OpenWeatherMapAPITesting.Weather_API_Services.HTTP_Manager;
using OpenWeatherMapAPITesting.Weather_API_Services.Data_Handling;

//we put all the calling and storing is done here.
namespace OpenWeatherMapAPITesting.Weather_API_Services
{
    class WeatherLatestsService
    {    //we need DTO
        public WeatherLatestDTO weatherLatestDTO = new WeatherLatestDTO();
        //WE NEED CALL MANAGER
        public WeatherLatestCallManager weatherLatestCallManager = new WeatherLatestCallManager();
        //Need JS obj.
        public JObject LatestWeatherJson;
        public WeatherLatestsService()
        {
            weatherLatestDTO.DeserializeLatestWeather(weatherLatestCallManager.getLatestWeather());
            LatestWeatherJson = JObject.Parse(weatherLatestCallManager.getLatestWeather());
        }
        internal WeatherLatestCallManager WeatherLatestCallManager { get => weatherLatestCallManager; set => weatherLatestCallManager = value; }
    }
}