using System;
using System.Threading.Tasks;
using What2Pack.ApiClient.Models;

namespace What2Pack.ApiClient
{
    public interface IWeatherClient
    {
        Task<RootObject> GetHistoricalWeatherDataAsync(string location, DateTime startDate, int duration);
        Task<RootObject> GetForecastedWeaterDataAsync(string location, int duration);
    }
}
