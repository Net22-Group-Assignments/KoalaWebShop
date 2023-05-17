using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Newtonsoft.Json;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Controllers
{
    public class CurrencyController : Controller
    {
        //        var client = new RestClient("https://api.apilayer.com/exchangerates_data/convert?to={to}&from={from}&amount={amount}");
        //        client.Timeout = -1;

        //var request = new RestRequest(Method.GET);
        //        request.AddHeader("apikey", "IteZQQFBVQ7bcr481MmJ04hfqwSctgFo");

        //IRestResponse response = client.Execute(request);
        //        Console.WriteLine(response.Content);

        Uri baseAdress = new Uri("https://api.apilayer.com/exchangerates_data/convert?to={to}&from={from}&amount={amount}");
        private readonly HttpClient _client;

        public CurrencyController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAdress;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<CurrencyViewModel> currencyList = new List<CurrencyViewModel>();
            HttpResponseMessage response = _client.GetAsync(_client.BaseAddress + "/currency/Get").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                currencyList = JsonConvert.DeserializeObject<List<CurrencyViewModel>>(data);
            }

            return View(currencyList);
        }
    }
}
