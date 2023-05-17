using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
        [ForeignKey(nameof(KoalaCustomers))]
        public int FK_KoalaCustomerId { get; set; }
        public KoalaCustomerApi KoalaCustomers { get; set; }
        public string SessionId { get; set; }
        public int Status { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Content { get; set; }
    }
}
