using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using What2Pack.ApiClient;
using What2Pack.ApiClient.Models;
using What2Pack.Services.Interfaces;

namespace What2Pack.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherClient _weatherClient;

        public WeatherService(IWeatherClient weatherClient)
        {
            _weatherClient = weatherClient;
        }

        public async Task<List<RootObject>> GetHistoricalWeatherAsync(string location, DateTime startDate, int duration)
        {
            var dateOneYearAgo = startDate.AddYears(-1);
            var oneYearAgo = await _weatherClient.GetHistoricalWeatherDataAsync(location, dateOneYearAgo, duration);
            var dateTwoYearsAgo = startDate.AddYears(-2);
            var twoYearsAgo = await _weatherClient.GetHistoricalWeatherDataAsync(location, dateTwoYearsAgo, duration);
            var dateThreeYearsAgo = startDate.AddYears(-3);
            var threeYearsAgo = await _weatherClient.GetHistoricalWeatherDataAsync(location, dateThreeYearsAgo, duration);
            List<RootObject> items = new List<RootObject>
            {
                oneYearAgo,
                twoYearsAgo,
                threeYearsAgo
            };
            return items;
        }

        public async Task<RootObject> WeatherAsyncNow(string location, int duration)
        {
            var forecastWeather = await _weatherClient.GetForecastedWeaterDataAsync(location, duration);
            return forecastWeather;
        }
    }
}
