using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

//here we get the connection string from config and make it static so it cant be changed.
namespace OpenWeatherMapAPITesting
{
    class WeatherConfig
    {
        public static readonly String baseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly String ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly String ApiUrlModOne = ConfigurationManager.AppSettings["access_key_url_mod_one"];
        public static readonly String ApiUrlModTwo = ConfigurationManager.AppSettings["access_key_url_mod_two"];
    }
}
