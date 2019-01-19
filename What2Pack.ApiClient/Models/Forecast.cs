using Newtonsoft.Json;
using System.Collections.Generic;

namespace What2Pack.ApiClient.Models
{
    public class Forecast
    {
        [JsonProperty("forecastday")]
        public List<ForecastDay> ForecastDay { get; set; }
    }
}
