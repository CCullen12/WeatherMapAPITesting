using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenWeatherMapAPITesting.Weather_API_Services.Data_Handling
{
    //here we gather the data that we get from the api.
    //lists commented out for testing reasons.
    public class List
    {
        public double dt { get; set; }
        public string dt_txt { get; set; }
        public WeatherMain main { get; set; }
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
        public string name { get; set; }
        //if added this it breaks everything.
        public Coord coord { get; set; }
        public string country { get; set; }
        public int timezone { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
    public class Coord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }
    public class LatestWeatherRoot
    {
        public int cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public City city { get; set; }
        //could make a list with the vables crated in it.
        //public List<Lists> lists { get; set; }
        public IList<List> list { get; set; }
    }
}