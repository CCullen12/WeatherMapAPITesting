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
            Assert.AreEqual(200, weatherLatestService.weatherLatestDTO.latestWeatherRoot.cod);
        }
        //this is a temp test for message as message can always change.
        [Test]
        public void MessageTest()
        {
            Assert.AreEqual("0.0111", weatherLatestService.weatherLatestDTO.latestWeatherRoot.message.ToString());
        }
        [Test]
        public void CntTest()
        {
            Assert.AreEqual(40, weatherLatestService.weatherLatestDTO.latestWeatherRoot.cnt);
        }
    }
}
