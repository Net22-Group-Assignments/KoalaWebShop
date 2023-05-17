using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Newtonsoft.Json;
using System;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Controllers
{
    public class CurrencyController : Controller
    {
        //public async Task<IActionResult> GetCurrency()
        //{
        //    var client = new RestClient("https://api.apilayer.com/exchangerates_data/latest?symbols={symbols}&base={base}");
        //    client.Timeout = -1;

        //    var request = new Restrequest(Method.GET);
        //    request.AddHeader("apikey", "IteZQQFBVQ7bcr481MmJ04hfqwSctgFo");

        //    IRestResponse response = client.Execute(request);
        //    Console.WriteLine(response.Content);

        //    return View(response);
        //}

        public async Task<IActionResult> Index()
        {
            List<CurrencyViewModel> currencyList = new List<CurrencyViewModel>();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://api.apilayer.com/exchangerates_data/latest?symbols=SEK,USD,EUR&base=SEK");
                var request = response.Headers.Add("apikey", "IteZQQFBVQ7bcr481MmJ04hfqwSctgFo");
                using (request)
                {
                    string apiResponse = await request.Content.ReadAsStringAsync();
                    currencyList = JsonConvert.DeserializeObject<List<CurrencyViewModel>>(apiResponse);
                }
            }
            return View(currencyList);
        }
    }
}
