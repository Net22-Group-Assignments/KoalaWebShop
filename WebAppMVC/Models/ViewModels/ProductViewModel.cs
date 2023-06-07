using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal PriceUSD { get; set; }
        public decimal PriceEUR { get; set; }
        public decimal Discount { get; set; }
        public string Content { get; set; }
        public int Quantity { get; set; }
        public string ImgURL { get; set; }

        public string CategoryTitle { get; set; }
    }
}
