

using Newtonsoft.Json;
namespace WeatherAPI
{
    public class WeatherInfo
    {
        [JsonProperty("id")]
        public  int ID;

        [JsonProperty("main")]
        public  string TypeWeather;


        [JsonProperty("description")]
        public  string Description;

        [JsonProperty("icon")]
        public  string IDIcon;

    }
}
