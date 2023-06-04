using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime PlacementTime { get; set; }

        //ForeignKey for Customer
        public int CustomerId { get; set; }
        public KoalaCustomer Customer { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
