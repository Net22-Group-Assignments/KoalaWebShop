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
        [Required]
        public int Quantity { get; set; }
       
        //ForeginKEy
        [ForeignKey("Category")]
        public int? FkCategory { get; set; }
        public Category? Category { get; set; }

        ICollection<Review>? Reviews { get; set; }
        
    }
}
