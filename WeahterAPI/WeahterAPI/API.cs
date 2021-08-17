
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeatherAPI
{
    public class API
    {
        public string ApiKey { get; private set; }

        public string NameCity { get; set; }
        public string Language { get; private set; }
        public string Units { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey">key api in OpenWeatherAPI</param>
        /// <param name="language">launguage response = ru, en, ja and etc</param>
        /// <param name="units">units in response = metrin or imperial</param>
        public API(string apiKey, string language, string units)
        {
            ApiKey = apiKey;
            if (language.Length > 2)
            {
                throw new APIException("the length must be less than 3");
            }
            else
            {
                Language = language;
            }

            CheckValue(units, "the measurement types are incorrect!", "metric", "imperial");
        }



        /// <summary>
        /// Async;
        /// Gets a response from OpenWeatherAPI
        /// </summary>
        /// <returns>Response from OpenWeatherAPI</returns>
        public async Task<Response> GetResponse()
        {


            HttpResponseMessage message;
            using (HttpClient httpClient = new())
            {
                message = await httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={NameCity}&appid={ApiKey}&lang={Language}&units={Units}");
            }

            string jsonText = await message.Content.ReadAsStringAsync();

            Response response = JsonConvert.DeserializeObject<Response>(jsonText);
            TryThrowExceptions(response);
            return response;



        }

        private static void TryThrowExceptions(Response response)
        {
            int codeResponse = response.CodeResult;

            switch (codeResponse)
            {
                case 404:
                    throw new APIException("error 404: Object not found");

                case 401:
                    throw new APIException("error 401: The necessary authentication data is missing or is not valid for the resource.");
                case 410:
                    throw new APIException("error 410: The requested resource is no longer available on the server.");
                case 413:
                    throw new APIException("error 413: The request size exceeds the limit.");
                case 423:
                    throw new APIException("error 423: The requested resource is blocked.");
                case 429:
                    throw new APIException("error 429: You should not try to repeat the request until a certain time has passed.");
                case 500:
                    throw new APIException("error 500: An internal server error occurred while processing the request.");

            }
        }

        private static void CheckValue(object objectToCheck, string textError, params object[] correctValues)
        {
          

            foreach (var correctValue in correctValues)
            {
                if (objectToCheck == correctValue) return;
            }
            throw new APIException(textError);
        }

    }
}
