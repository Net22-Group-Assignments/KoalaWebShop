using WebAppMVC.Models.CurrencyModel;

namespace WebAppMVC.Models.ViewModels
{
    public class CurrencyViewModel
    {
        public DateTime Date { get; set; }
        public string Base { get; set; }
        public decimal Rate { get; set; }
    }
}
