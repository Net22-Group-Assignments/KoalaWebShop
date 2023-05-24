using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        [StringLength(40)]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        [Required]
        public int Quantity { get; set; }
        public string ImgURL { get; set; }

        //ForeginKEy
        [ForeignKey("Category")]
        public int? FkCategory { get; set; }
        public Category? Category { get; set; }

        public ICollection<Review>? Reviews { get; set; }
    }
}
