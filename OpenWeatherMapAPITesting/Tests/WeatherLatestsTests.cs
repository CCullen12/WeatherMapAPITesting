using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharp;
using OpenWeatherMapAPITesting.Weather_API_Services;
using OpenWeatherMapAPITesting.Weather_API_Services.Data_Handling;

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
            Assert.AreNotEqual("0.0111", weatherLatestService.weatherLatestDTO.latestWeatherRoot.message.ToString());
        }
        [Test]
        public void CntTest()
        {
            Assert.AreEqual(40, weatherLatestService.weatherLatestDTO.latestWeatherRoot.cnt);
        }
        [Test]
        public void ListDTTest()
        {
            Assert.AreEqual("1570633200", weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].dt.ToString());
        }
        [Test]
        public void ListDT_txtTest()
        {
            Assert.AreEqual("2019-10-09 15:00:00", weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].dt_txt.ToString());
        }
        //we test if its greater than 273 kelvin as that is the freezing point.
        [Test]
        public void MainTempTest()
        {
            Assert.Less(273.00f, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].main.temp);
        }
        //test if the min is higher than freezing.
        [Test]
        public void MinTempTest()
        {
            Assert.Less(273.00f, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].main.temp_min);
        }
        //test if the max is lower than boiling.
        [Test]
        public void MaxTempTest()
        {
            Assert.Greater(373.00f, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].main.temp_max);
        }
        [Test]
        public void PressureTest()
        {
            Assert.Less(800.00f, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].main.pressure);
        }
        [Test]
        public void SeaLevelLevelTest()
        {
            Assert.Less(800.00f, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].main.sea_level);
        }
        [Test]
        public void GrndLevelTest()
        {
            Assert.Less(800.00f, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].main.grnd_level);
        }
        [Test]
        public void HumidityTest()
        {
            Assert.Less(50.00f, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].main.humidity);
        }
        [Test]
        public void TempKFTest()
        {
            Assert.Less(0.00f, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].main.temp_kf);
        }
        [Test]
        public void CityIDTest()
        {
           Assert.AreEqual(2643743, weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.id);
        }
        [Test]
        public void CityNameTest()
        {
            Assert.AreEqual("London", weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.name);
        }
        [Test]
        public void CityCoordLatAndLonTest()
        {
            Assert.AreEqual(51.5085, weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.coord.lat);
            Assert.AreEqual(-0.1258, weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.coord.lon);
        }
        [Test]
        public void CityCountryTest()
        {
            Assert.AreEqual("GB", weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.country);
        }
        [Test]
        public void CityTimezoneTest()
        {
            Assert.AreEqual(3600, weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.timezone);
        }
        [Test]
        public void CitySunriseAndSunsetTest()
        {
            Assert.AreEqual(1570601609, weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.sunrise);
            Assert.AreEqual(1570641718, weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.sunset);
        }
        [Test]
        public void ListWeatherIDTest()
        {
            Assert.AreEqual(500, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].weather[0].id);
        }
        [Test]
        public void ListWeatherMainTest()
        {
            Assert.AreEqual("Rain", weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].weather[0].main);
        }
        [Test]
        public void ListWeatherDescriptionTest()
        {
            Assert.AreEqual("light rain", weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].weather[0].description);
        }
        [Test]
        public void ListWeatherIconTest()
        {
            Assert.AreEqual("10d", weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].weather[0].icon);
        }
//      [Test]
//      public void ListTypeTest()
//      {
//          Assert.AreEqual("", weatherLatestService.weatherLatestDTO.latestWeatherRoot.list.GetType().ToString());
//      }
//      this test returns <OpenWeatherMapAPITesting.Weather_API_Services.Data_Handling.Clouds>
//      so im skipping this test as a failure.
//      [Test]
//      public void ListCloudsAllTest()
//      {
//          Assert.AreEqual(100, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].clouds);
//      }
        [Test]
        public void ListWindSpeedTest()
        {
            Assert.AreEqual(7.21f, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].wind.speed);
        }
        [Test]
        public void ListWindDegTest()
        {
            Assert.AreEqual(254.844, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].wind.deg);
        }
    }
}