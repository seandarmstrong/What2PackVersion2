﻿using Newtonsoft.Json;

namespace What2Pack.ApiClient.Models
{
    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("lat")]
        public decimal Lat { get; set; }
        [JsonProperty("lon")]
        public decimal Lon { get; set; }
        [JsonProperty("tz_id")]
        public string TzId { get; set; }
        [JsonProperty("localtime_epoch")]
        public decimal LocaltimeEpoch { get; set; }
        [JsonProperty("localtime")]
        public string Localtime { get; set; }
    }
}
