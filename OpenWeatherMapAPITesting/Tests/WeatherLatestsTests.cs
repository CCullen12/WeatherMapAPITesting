using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharp;
using OpenWeatherMapAPITesting.Weather_API_Services;

namespace OpenWeatherMapAPITesting.Tests
{
    [TestFixture]
    class WeatherLatestsTests
    {
        private WeatherLatestsService weatherLatestService = new WeatherLatestsService();
        //this is just to start up a frame work.
        [Test]
        public void ConnectionTest()
        {
            Assert.AreEqual("200", weatherLatestService.weatherLatestDTO.latestWeatherRoot.cod.ToString());
        }

    }
}
