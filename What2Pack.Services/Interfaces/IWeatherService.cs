using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using What2Pack.ApiClient.Models;

namespace What2Pack.Services.Interfaces
{
    public interface IWeatherService
    {
        Task<List<RootObject>> GetHistoricalWeatherAsync(string location, DateTime startDate, int duration);
        Task<RootObject> WeatherAsyncNow(string location, int duration);
    }
}
