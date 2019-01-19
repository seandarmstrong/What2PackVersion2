using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;
using What2Pack.ApiClient.Models;

namespace What2Pack.ApiClient
{
    public class WeatherClient : IWeatherClient
    {
        private readonly RestClient _restClient;
        private readonly IOptions<ApiVariables> _options;

        public WeatherClient(IOptions<ApiVariables> options)
        {
            _restClient = new RestClient("https://api.apixu.com/");
            _options = options;
        }

        public async Task<RootObject> GetHistoricalWeatherDataAsync(string location, DateTime startDate, int duration)
        {
            var beginDate = startDate.ToString("yyyy/MM/dd");
            var endDate = startDate.AddDays(duration - 1).ToString("yyyy/MM/dd");
            var request = new RestRequest(string.Format("v1/history.json?key={0}={1}&dt={2}&end_dt={3}", _options.Value.Key, location, beginDate, endDate), Method.GET);

            var response = await _restClient.ExecuteTaskAsync(request);

            var data = JsonConvert.DeserializeObject<RootObject>(response.Content);
            return data;
        }

        public async Task<RootObject> GetForecastedWeaterDataAsync(string location, int duration)
        {
            var requestNow = new RestRequest(string.Format("v1/forecast.json?key={0}={1}&days={2}", _options.Value.Key, location, duration), Method.GET);
            var response = await _restClient.ExecuteTaskAsync(requestNow);
            var data = JsonConvert.DeserializeObject<RootObject>(response.Content);
            return data;
        }
    }
}
