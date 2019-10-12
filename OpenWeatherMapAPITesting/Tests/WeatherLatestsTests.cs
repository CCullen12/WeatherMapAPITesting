using NUnit.Framework;
using OpenWeatherMapAPITesting.Weather_API_Services;

//this file is for all the testing. we have it all in one place so that
//it is much easier to read.
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
        //this will always change so we are just checking if the string has the correct lenght.
        [Test]
        public void ListDTTest()
        {
            Assert.AreEqual(10, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].dt.ToString().Length);
        }
        //this will always change so we are just checking if the string has the correct lenght.
        [Test]
        public void ListDT_txtTest()
        {
            Assert.AreEqual(19, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].dt_txt.ToString().Length);
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
            Assert.IsInstanceOf(typeof(float), weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].main.temp_kf);
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
        public void CityCoordLatTest()
        {
            Assert.AreEqual(51.5085, weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.coord.lat);
        }
        [Test]
        public void CityCoordLonTest()
        {
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
        //Sunrise and sunset tests will be chaning daily so we cant really get a good test that will always pass on them.
        [Test]
        public void CitySunriseTest()
        {
            Assert.Greater(1570961110, weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.sunrise);
        }
        [Test]
        public void CitySunsetTest()
        {
            Assert.Less(1570641718, weatherLatestService.weatherLatestDTO.latestWeatherRoot.city.sunset);
        }
        //as the id can change we check if what is returned is a double.
        [Test]
        public void ListWeatherIDTest()
        {
            Assert.IsInstanceOf(typeof(double), weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].weather[0].id);
        }
        //as the weater constantly changes we check if what is returned is a string.
        [Test]
        public void ListWeatherMainTest()
        {
            Assert.IsInstanceOf(typeof(string), weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].weather[0].main);
        }
        //as the description changes based on weather we test if it returns a string.
        [Test]
        public void ListWeatherDescriptionTest()
        {
            Assert.IsInstanceOf(typeof(string), weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].weather[0].description);
        }
        [Test]
        public void ListWeatherIconTest()
        {
            Assert.IsInstanceOf(typeof(string), weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].weather[0].icon);
        }
        [Test]
        public void ListWindSpeedTest()
        {
            Assert.IsInstanceOf(typeof(float), weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].wind.speed);
        }
        [Test]
        public void ListWindDegTest()
        {
            Assert.IsInstanceOf(typeof(double), weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].wind.deg);
        }
        //im not too sure on what pod is.
        [Test]
        public void ListSysPodTest()
        {
            Assert.AreEqual(1, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].sys.pod.Length);
        }
        //this will always change so we are just checking if the string has the correct lenght.
        [Test]
        public void ListDtLengthTest()
        {
            Assert.AreEqual(10, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[0].dt.ToString().Length);
        }
        //this will always change so we are just checking if the string has the correct lenght.
        [Test]
        public void ListDtPtTwoLengthTest()
        {
            Assert.AreEqual(10, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[1].dt.ToString().Length);
        }
        //this will always change so we are just checking if the string has the correct lenght.
        [Test]
        public void ListDtPtThreeTest()
        {
            Assert.AreEqual(10, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[2].dt.ToString().Length);
        }
        //this will always change so we are just checking if the string has the correct lenght.
        [Test]
        public void ListDtPtFourTest()
        {
            Assert.AreEqual(10, weatherLatestService.weatherLatestDTO.latestWeatherRoot.list[3].dt.ToString().Length);
        }
    }
}