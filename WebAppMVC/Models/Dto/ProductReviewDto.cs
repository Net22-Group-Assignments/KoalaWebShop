using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models.Dto
{
    public class ProductReviewDto
    {
        public int ProductReviewId { get; set; }
        public int FK_ProductId { get; set; }
        public int ParentId { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Content { get; set; }
    }
}
