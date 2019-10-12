# WeatherMapAPITesting
In this project i was tasked to create tests for the  open API openweathermap.org using the forcast route that updates every 3 hours. It also targets for the weather in london. Example link: http://api.openweathermap.org/data/2.5/forecast?id=2643743 You will need to create an account with openweathermap to use a key to use the site properly.

# Installation
To run this project you first need to have visual studio installed.  
Clone/download this repository.  
Opening the "OpenWeatherMapAPITesting.sln" file from the root.  
Make sure the project it built by clicking "build" at the top of the visual studio and then pressing "build solution".  
If you are unable to find a panel called solution explorer you need to click on "view" then "solution explorer".  
In solution explorer right click on "OpenWeatherMapAPITesting" and click on "Manage NuGet Packages".  
To check if Packages are already installed you can look on the Installed tab, If not install Packages talked about below.  
To run the tests developed by me locate the top of your visual studio and press "Test" then press "Windows" and "Test Explorer" this should create a panel to make it easier for you to view all the tests.  
Next you can Press the "run all" button to run all the tests that have been created or you can open "OpenWeatherMapAPITesting" to see each individual test.  
Here you can right click on each test and click "Run selected tests" to run only that test.

# NuGet Packages
Make sure that the following NuGet Packages are installed to run this software.
* Newtonsoft.Json. This enables us to use the JSON framwork for . 
* NUnit. This enables us to do unit testing on the API.
* NUnit3TestAdapter. This enables us to run NUnit in visual studio.
* RestSharp. This is used for REST and HTTP API client connection.

# Tests
There are a total of 32 tests. Using postman as guidence i checked every value in the first array/list part of the return values. There are unfortunally no header tests.
* ConenctionTest checks if the connection happened.
* MessageTest checks if you didnt get the first message i did.
* CntTest checks if the Cnt value is 40, which is how many lines have been returned by the api call.
* ListDTtest changes the Date number into a string and checks if its the correct length.
* ListDT_txtTest same as above but checks if length is 19.
* MainTempTest checks if temp is above freezing.
* MinTempTest checks if min temp is above freezing.
* MaxTempTest checks if max temp is below boiling.
* Pressure Sealevel and Grndlevel tests check if value returned is about 800, this is a random value as i dont have any knowlage about this topic.
* TempKFTest we check if the returned type is a float.
* City ID, Country and Name Tests check if we made the right call to the city that we want.
* City lat and lon Tests check the lat and lon returned.
* City timezone we check if returned 3600. gmt.
* Sunrise and sunset tests will always been changing as the date will always change.
* We check for the following for return types as their values change daily: ListWeatherIDTest, ListWeatherMainTest, ListWeatherDescriptionTest, ListWeatherIconTest, ListWindSpeedTest, ListWindDegTest
* ListSysPodTest checks if the pod returned is 1.
* the last 4 tests are checking if the DT returned by the first 4 elements of array list all have the length of 10. 

