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
		public async Task<IActionResult> Index()
		{
			List<Currency> currencies = new List<Currency>();

			string apiUrl = "https://api.apilayer.com/exchangerates_data/latest?symbols=SEK,USD,EUR&base=SEK";
			string apiKey = "IteZQQFBVQ7bcr481MmJ04hfqwSctgFo";

			string fullUrl = $"{apiUrl}&apikey={apiKey}";

			var request = new HttpRequestMessage(HttpMethod.Get, fullUrl);

			using (var response = await GetHttpClient().SendAsync(request))
			{

				if (response.IsSuccessStatusCode)
				{

					string responseBody = await response.Content.ReadAsStringAsync();

					JsonDocument jsonDoc = JsonDocument.Parse(responseBody);

					Currency currency = JsonConvert.DeserializeObject<Currency>(responseBody);

					currencies.Add(currency);


					//_context.Add(currency);
					//_context.SaveChanges();

					CloseHttpClient();

					return View(responseBody);
				}
				else
				{
					string errorMessage = $"API request failed with status code: {response.StatusCode}";

					CloseHttpClient();

					return View(errorMessage);
				}
			}
		}
	}
}
