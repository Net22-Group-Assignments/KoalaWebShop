using WebAppMVC.Models.CurrencyModel;

namespace WebAppMVC.Models.ViewModels
{
    public class CurrencyViewModel
    {
        public int CurrencyId { get; set; }
        public string success { get; set; }
        public int timestamp { get; set; }
        public string @base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
    }
}
