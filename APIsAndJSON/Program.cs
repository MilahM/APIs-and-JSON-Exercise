using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region RonVSKanye
            //var client = new HttpClient();
            //var quote = new RonVSKanyeAPI(client);

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("------------------------");
            //    Console.WriteLine($"Kanye: {quote.KanyeQuote()}");

            //    Console.WriteLine($"Ron Swanson: {quote.RonQuote()}");
            //}
            #endregion

            #region OpenWeatherMap
            string key = File.ReadAllText("appsettings.json");

            string APIKey = JObject.Parse(key).GetValue("Default key").ToString();

            Console.WriteLine("Please enter your Zip Code.");
            var zipCode = Console.ReadLine();

            string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIKey}&units=imperial";

            Console.WriteLine();
            Console.WriteLine($"The current temperature in your location is {OpenWeatherMapAPI.GetTemp(apiCall)}");
            #endregion
        }
    }
}