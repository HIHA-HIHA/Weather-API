
using Newtonsoft.Json;

namespace WeatherAPI
{
    public class MainInformation
    {
        [JsonProperty("temp")]
        public float Temperature;

        [JsonProperty("feels_like")]
        public float TemperatureFeelsLike;

        [JsonProperty("temp_max")]
        public float MaxTemperature;

        [JsonProperty("temp_min")]
        public float MinTemperature;

        [JsonProperty("pressure")]
        public float Pressure;

        [JsonProperty("Humidity")]
        public float Humidity;
    }
}
