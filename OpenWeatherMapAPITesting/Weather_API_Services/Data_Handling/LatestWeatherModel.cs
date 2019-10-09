using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapAPITesting.Weather_API_Services.Data_Handling
{
    //here we gather the data that we get from the api.
    public class Lists
    {
        public int dt { get; set; }
        public string dt_text { get; set; }
        public WeatherMain Wmain { get; set; }
    }

    public class WeatherMain{
        public float temp { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public float pressure { get; set; }
        public float sea_level { get; set; }
        public float grnd_level { get; set; }
        public float humidity { get; set; }
        public float temp_kf { get; set; }
    }
    public class City
    {
        public int id { get; set; }
    }
    public class LatestWeatherRoot
    {
        public int cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
    }
}
