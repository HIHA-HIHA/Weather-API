using Newtonsoft.Json;

namespace WeahterAPI
{
    public class CloudInfo
    {
        [JsonProperty("all")]
        public float CloudOver;

    }
}
