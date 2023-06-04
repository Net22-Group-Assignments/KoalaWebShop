using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAppMVC.Models.ViewModels
{
    public class ModifyProductViewModel
    {
        public int? ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Content { get; set; }
        public int Quantity { get; set; }
        public string ImgURL { get; set; }

        [DisplayName("Category")]
        public int CategoryId { get; set; }

        public IFormFile File { get; set; }

        public SelectList Categories { get; set; }
    }
}
