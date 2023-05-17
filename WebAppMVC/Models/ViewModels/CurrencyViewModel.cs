namespace WebAppMVC.Models.ViewModels
{
    public class CurrencyViewModel
    {
        public DateTime Date { get; set; }
        public string Base { get; set; }
        public decimal SEKrate { get; set; }
        public decimal USDrate { get; set; }
        public decimal EURrate { get; set; }
    }
}
