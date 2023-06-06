using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebAppMVC.Models.Dto
{
    public class ProductDto
    {
        public string Title { get; set; }
        public decimal? Price { get; set; }

        public decimal? Discount { get; set; }
        public string Content { get; set; }
        public int? Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
