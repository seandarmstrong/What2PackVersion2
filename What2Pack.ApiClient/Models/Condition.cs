using Newtonsoft.Json;

namespace What2Pack.ApiClient.Models
{
    public class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("code")]
        public decimal Code { get; set; }
    }
}
