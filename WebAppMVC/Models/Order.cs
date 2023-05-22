using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cartId { get; set; }
        [Display(Name ="Order No")]
        public string OrderNo { get; set; }
        //ForeignKey for Customer
        [ForeignKey("koalaId")]
        public int FkCustomerId { get; set; }
        public KoalaCustomer koalaId { get; set; }

        public ICollection<Product> products { get; set; }


    }
}
