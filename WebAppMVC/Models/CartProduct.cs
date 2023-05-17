using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class CartProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartProductId { get; set; }
        [ForeignKey(nameof(Products))]
        public int Fk_ProductId { get; set; }
        public Product Products { get; set; }
        [ForeignKey(nameof(Carts))]
        public int FK_CartId { get; set;}
        public Cart Carts { get; set; }
    }
}
