using Newtonsoft.Json;

namespace WeatherAPI
{
    public class CloudInfo
    {
        [JsonProperty("all")]
        public float CloudOver;

    }
}
