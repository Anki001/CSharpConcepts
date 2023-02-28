// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using SystemTextJson;

var wetherForCast = new WeatherForecast
{
    Date = DateTime.Parse("2019-08-01"),
    TemperatureCelsius = 25,
    Summary = "Hot"
};

string jsonString = JsonSerializer.Serialize(wetherForCast);

Console.WriteLine($"Serialize string is \n {jsonString}");

WeatherForecast? newWetherForcastObj = JsonSerializer.Deserialize<WeatherForecast>(jsonString);

Console.ReadLine();