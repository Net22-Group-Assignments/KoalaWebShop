using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCategoryId { get; set; }
        [ForeignKey(nameof(Categorys))]
        public int FK_CategoryId { get; set; }
        public Category Categorys { get; set; }
        [ForeignKey(nameof(Products))]
        public int FK_ProductId { get; set; }
        public Product Products { get; set; }
    }
}
