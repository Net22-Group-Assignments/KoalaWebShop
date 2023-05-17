using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Required]
        public int parentId { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Content { get; set; }
    }
}
