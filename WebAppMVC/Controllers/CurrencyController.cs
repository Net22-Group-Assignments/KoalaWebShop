using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Text.Json;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Models.CurrencyModel;
using WebAppMVC.Models.ViewModels;
using static WebAppMVC.Repository.HttpClientRepository;

namespace WebAppMVC.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CurrencyController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            string apiUrl = "https://api.apilayer.com/exchangerates_data/latest?symbols=SEK,USD,EUR&base=SEK";
            string apiKey = "IteZQQFBVQ7bcr481MmJ04hfqwSctgFo";

            string fullUrl = $"{apiUrl}&apikey={apiKey}";

            var request = new HttpRequestMessage(HttpMethod.Get, fullUrl);

            using (var httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromSeconds(10);

                using (var response = await httpClient.SendAsync(request))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        var currency = JsonConvert.DeserializeObject<Currency>(responseBody);

                        if (!_context.Currencies.Any())
                        {
                            _context.Currencies.Add(currency);
                            await _context.SaveChangesAsync();

                        }
                        else
                        {
                            _context.Currencies.Update(currency);
                            await _context.SaveChangesAsync();

                        }


                        return View(currency);
                    }
                    else
                    {
                        string errorMessage = $"API request failed with status code: {response.StatusCode}";

                        
                        return View(errorMessage);
                    }
                }
            }
        }
    }
}
