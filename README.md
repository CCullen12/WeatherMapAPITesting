# WeatherMapAPITesting
In this project we are tasked to create tests for the  open API openweathermap.org

# Reading an API
To read information from an API online and test it we need some classes and methods in place.

# # Classes

# # Weather API Services
# WeatherLatestsService
Here is where we call the API and store it into the Data model transfer class (DTO).

# # Data Handling
# LatestWeatherModel
Here we recreate the structure from the json file that we get from the API into a c# friendly environment where we are more easily able to both read and do tests on the API.

# WeatherLatestDTO
Here we grab the json file from the the API we connected to and Deserialized it into the root class of the model file.

# # HTTP Manager
# WeatherLatestCallManager
Here we connect to the client using our configurations with the connection strings that we need and return the responce for the datamodel to be able to use.

# # Tests
# WeatherLatestsTests
Here is where we do all the testing of the weather API.

# App.config
Here we add the string to connection using appsettings add key to each part of the string. we need 4 of these as the & simbol in xml thinks that whats after it class.

# Program
I created this application as a console app thinking that i would need to output some varables to the console if i couldnt get it through testing. Found out that i didnt need to do that later onto development.

# WeatherConfig
This gets the infomation from App.config and puts it into c# friendly terms for later use. we also make all varables into static so that it wont be able to be changed later on as its public.

