using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        //ForeignKey for Customer
        public int CustomerId { get; set; }
        public KoalaCustomer Customer { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
    }
}
