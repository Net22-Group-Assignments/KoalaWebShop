using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductReviewId { get; set; }
        public string Title { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Content { get; set; }
        

        //ForeginKey
        [ForeignKey("Products")]
        public int FK_ProductId { get; set; }
        public Product Products { get; set; }
    }
}
