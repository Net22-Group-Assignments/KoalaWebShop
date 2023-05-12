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
        public string Summary { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
