using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Newtonsoft.Json;
using RestSharp;
using System;
using WebAppMVC.Models.ViewModels;
using Method = RestSharp.Method;

namespace WebAppMVC.Controllers
{
    public class CurrencyController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetCurrency()
        {
            var client = new RestClient("https://api.apilayer.com/exchangerates_data/latest?symbols={symbols}&base={base}");

            var request = new RestRequest(Method.Get.ToString());
            request.AddHeader("apikey", "IteZQQFBVQ7bcr481MmJ04hfqwSctgFo");

            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);

            return View(response);
        }

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
