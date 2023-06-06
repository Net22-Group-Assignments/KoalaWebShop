using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models.Dto
{
    public class ReviewDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        //ForeginKey
        public int FK_ProductId { get; set; }
    }
}
