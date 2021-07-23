
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace WeahterAPI
{
    public class API
    {
        public static string apiKey = "";

        public static string NameCity;
        public static string Language = "ru";
        public static string Units = "metric";

        

        public static async Task<Response> GetInfoAboutCity()
        {

            try
            {
                HttpResponseMessage message;
                using (HttpClient httpClient = new HttpClient())
                {
                     message = await httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={NameCity}&appid={apiKey}&lang={Language}&units={Units}");
                }

                string jsonText = await message.Content.ReadAsStringAsync();

                Response response = JsonConvert.DeserializeObject<Response>(jsonText);
                return response;
            }
            catch
            {
                throw new APIException("Херня какая та");
            }
            
        }

        
 
    }
}
