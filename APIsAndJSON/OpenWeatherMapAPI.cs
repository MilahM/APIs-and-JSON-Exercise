using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        private HttpClient _client;

        public OpenWeatherMapAPI(HttpClient client)
        {
            _client = client;
        }

        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            var weatherResponse = client.GetStringAsync(apiCall).Result;

            var weatherTemp = double.Parse(JObject.Parse(weatherResponse)["main"]["temp"].ToString());

            return weatherTemp;
        }
       


    }
}
