

using Newtonsoft.Json;

namespace WeahterAPI
{
    public class Response
    {
        [JsonProperty("weather")]
        public  WeatherInfo[] Weather;

        [JsonProperty("main")]
        public  MainInformation MainInformation;

        [JsonProperty("wind")]
        public  WindInfo InformationAboutWind;

        [JsonProperty("clouds")]
        public  CloudInfo InformationAboutClouds;

        [JsonProperty("visibility")]
        public  float Visibility;

        [JsonProperty("id")]
        public  string ID;

        [JsonProperty("name")]
        public  string NameCity;

        [JsonProperty("cod")]
        public  int CodeResult;



    }
}
