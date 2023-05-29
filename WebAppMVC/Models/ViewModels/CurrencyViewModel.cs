namespace WebAppMVC.Models.ViewModels
{
    public class CurrencyViewModel
    {
        public string Date { get; set; }
        public string Base { get; set; }
        public decimal RateSEK { get; set; }
		public decimal RateUSD { get; set; }
		public decimal RateEUR { get; set; }
	}
}
