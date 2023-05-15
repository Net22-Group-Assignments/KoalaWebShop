using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class ProductReview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductReviewId { get; set; }
        [ForeignKey(nameof(Products))]
        public int FK_ProductId { get; set; }
        public Product Products { get; set; }
        public int ParentId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
