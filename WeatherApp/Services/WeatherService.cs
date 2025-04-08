using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Extensions;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly string _apiKey;

        public WeatherService()
        {
            var key = App.Configuration.GetSection("ApiKeys")["WeatherApi"];
            if (string.IsNullOrEmpty(key))
            {
                throw new Exception("Weather API key not found in appsettings.json");
            }
            _apiKey = key;
        }

        public async Task<Weather> GetWeatherByCityNameAsync(string cityName)
        {
            // Опция, необходимая для корректной десериализации данных JSON из openweathermap
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new WeatherJsonConverter());

            // Вызовите API погоды, используя HttpClient

            // Десериализуйте ответ в объект Weather

            // Верните объект Weather

            throw new NotImplementedException();
        }

        public async Task<Weather> GetWeatherByGeoAsync(double longitude, double latitude)
        {
            // Опция, необходимая для корректной десериализации данных JSON из openweathermap
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new WeatherJsonConverter());

            // Вызовите API погоды, используя HttpClient

            // Десериализуйте ответ в объект Weather

            // Верните объект Weather

            throw new NotImplementedException();
        }

        public async Task<List<City>> GetGeoByCityNameAsync(string cityName, int limit=1)
        {
            // Опция, необходимая для корректной десериализации данных JSON из openweathermap
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new CityJsonConverter());

            // Вызовите географическое API, используя HttpClient

            // Десериализуйте ответ в список объектов City

            // Верните список City

            throw new NotImplementedException();
        }
    }
}

