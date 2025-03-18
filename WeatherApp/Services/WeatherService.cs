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
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new WeatherJsonConverter());

            // Call the weather API

            // Parse the response

            // Return the weather object

            throw new NotImplementedException();
        }

        public async Task<Weather> GetWeatherByGeoAsync(double longitude, double latitude)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new WeatherJsonConverter());

            // Call the weather API

            // Parse the response

            // Return the weather object

            throw new NotImplementedException();
        }

        public async Task<City> GetGeoByCityNameAsync()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            options.Converters.Add(new CityJsonConverter());

            // Call the weather API

            // Parse the response

            // Return the weather object

            throw new NotImplementedException();
        }
    }
}

