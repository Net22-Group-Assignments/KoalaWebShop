using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Text.Json;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Models.CurrencyModel;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Controllers
{
	[Authorize(Roles = "Admin")]
	public class CurrencyController : Controller
	{
		private readonly ApplicationDbContext _context;
		public CurrencyController(ApplicationDbContext context)
		{
			_context = context;
		}
		public async Task<IActionResult> Index()
		{
			List<CurrencyViewModel> currencyViewModels = new List<CurrencyViewModel>();

			var currency = await (from c in _context.Currencies
								  select new
								  {
									  Success = c.success,
									  TimeStamp = c.timestamp,
									  Base = c.@base,
									  Date = c.date,
									  RateSEK = c.rates.SEK,
									  RateUSD = c.rates.USD,
									  RateEUR = c.rates.EUR
								  }).ToListAsync();

			foreach (var item in currency)
			{
				CurrencyViewModel listItem = new CurrencyViewModel();

				listItem.Timestamp = item.TimeStamp;
				listItem.Date = item.Date;
				listItem.Base = item.Base;
				listItem.RateSEK = item.RateSEK;
				listItem.RateUSD = item.RateUSD;
				listItem.RateEUR = item.RateEUR;
				currencyViewModels.Add(listItem);
			};
			return View(currencyViewModels);
		}

		public async Task<ActionResult> GetCurrency()
		{
			string apiUrl = "https://api.apilayer.com/exchangerates_data/latest?symbols=SEK,USD,EUR&base=SEK";
			string apiKey = "IteZQQFBVQ7bcr481MmJ04hfqwSctgFo";

			string fullUrl = $"{apiUrl}&apikey={apiKey}";

			var request = new HttpRequestMessage(HttpMethod.Get, fullUrl);

			using (var httpClient = new HttpClient())
			{
				httpClient.Timeout = TimeSpan.FromSeconds(90);

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
							var oldCurrency = await _context.Currencies.Include(c => c.rates).FirstOrDefaultAsync();
							oldCurrency.success = currency.success;
							oldCurrency.timestamp = currency.timestamp;
							oldCurrency.@base = currency.@base;
							oldCurrency.date = currency.date;
							oldCurrency.rates.SEK = currency.rates.SEK;
							oldCurrency.rates.USD = currency.rates.USD;
							oldCurrency.rates.EUR = currency.rates.EUR;

							await _context.SaveChangesAsync();

						}

						return RedirectToAction("Index");
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