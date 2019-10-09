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
