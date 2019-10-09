using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace OpenWeatherMapAPITesting.Weather_API_Services.HTTP_Manager
{
    class WeatherLatestCallManager
    {
        readonly IRestClient client;
        public WeatherLatestCallManager()
        {
            client = new RestClient(WeatherConfig.baseUrl);
        }
        public string getLatestWeather()
        {
            //reason we have the "&" seperate from the weatherconfig is that xml thinks that the &API is a class and doesnt 
            //reconise that its within a string.
            var requests = new RestRequest( WeatherConfig.ApiUrlModOne + "&" + WeatherConfig.ApiUrlModTwo + WeatherConfig.ApiKey);
            var response = client.Execute(requests, Method.GET);
            return response.Content;
        }
    }
}