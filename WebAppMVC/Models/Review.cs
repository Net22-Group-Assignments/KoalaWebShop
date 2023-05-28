using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Title { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }
        public string ImgURL { get; set; }

        // Foreign Key
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        // Foreign Key
        public int CustomerId { get; set; }
        public KoalaCustomer Customer { get; set; }
    }
}
