using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cartId { get; set; }
        
        //ForeignKey for Customer
        [ForeignKey("koalaId")]
        public int FkCustomerId { get; set; }
        public KoalaCustomer KoalaId { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
