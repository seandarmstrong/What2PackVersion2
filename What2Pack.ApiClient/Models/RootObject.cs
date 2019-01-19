using Newtonsoft.Json;

namespace What2Pack.ApiClient.Models
{
    public class RootObject
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("forecast")]
        public Forecast Forecast { get; set; }
    }
}
