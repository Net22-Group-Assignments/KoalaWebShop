using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Title { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        [Precision(18, 6)]
        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        [Required]
        public int Quantity { get; set; }
        public string ImgURL { get; set; }

        // Foreign Key
		public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
