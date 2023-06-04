using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal PriceUSD { get; set; }

        public decimal PriceEUR { get; set; }
        public decimal Discount { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        [Required]
        public int Quantity { get; set; }
        public string ImgURL { get; set; }
        // Currency exchange rates
        public decimal RateSEK { get; set; }
        public decimal RateUSD { get; set; }
        public decimal RateEUR { get; set; }
    }
}
