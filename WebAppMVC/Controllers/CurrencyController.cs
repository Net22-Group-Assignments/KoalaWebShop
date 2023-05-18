using Microsoft.AspNetCore.Mvc;

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
