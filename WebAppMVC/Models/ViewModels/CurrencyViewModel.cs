using System.ComponentModel;

namespace WebAppMVC.Models.ViewModels
{
    public class CurrencyViewModel
    {
        public int Timestamp { get; set; }
        public string Date { get; set; }
        public string Base { get; set; }

        [DisplayName("RATE SEK")]
        public decimal RateSEK { get; set; }

        [DisplayName("RATE USD")]
        public decimal RateUSD { get; set; }

        [DisplayName("RATE EUR")]
        public decimal RateEUR { get; set; }
    }
}
