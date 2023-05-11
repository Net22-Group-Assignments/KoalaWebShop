using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [ForeignKey(nameof(Users))]
        public int FK_UserId { get; set; }
        public User Users { get; set; }
        public int Status { get; set; }
        public float ItemDiscount { get; set; }
        public float Totalamount { get; set; }
        public int NumberOfItems { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        [StringLength(500)]
        public string Content { get; set; }

    }
}
