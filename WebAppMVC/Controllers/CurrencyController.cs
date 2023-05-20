using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Text.Json;

namespace WebAppMVC.Controllers
{
    public class CurrencyController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<IActionResult> Index()
        {
            string apiUrl = "https://api.apilayer.com/exchangerates_data/latest?symbols=SEK,USD,EUR&base=SEK";
            string apiKey = "IteZQQFBVQ7bcr481MmJ04hfqwSctgFo";

            string fullUrl = $"{apiUrl}&apikey={apiKey}";

            var request = new HttpRequestMessage(HttpMethod.Get, fullUrl);

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {

                string responseBody = await response.Content.ReadAsStringAsync();

                JsonDocument jsonDoc = JsonDocument.Parse(responseBody);

                string usd = jsonDoc.RootElement.GetProperty("rates").GetProperty("USD").ToString();
				string eur = jsonDoc.RootElement.GetProperty("rates").GetProperty("EUR").ToString();
				string sek = jsonDoc.RootElement.GetProperty("rates").GetProperty("SEK").ToString();
				string currency = jsonDoc.RootElement.GetProperty("rates").ToString();

				Console.WriteLine($"usd: {usd}\neur: {eur}\nsek: {sek}");

                Console.WriteLine(currency);

                Console.WriteLine(responseBody);

                return View(responseBody);
			}
            else
            {
                string errorMessage = $"API request failed with status code: {response.StatusCode}";

                return View(errorMessage);
            }
		}
    }
}
