using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class KoalaCustomer : IdentityUser<int>
    {
        [Required]
        [StringLength(40)]
        public string FirstMidName { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        public decimal Credits { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

        public ICollection<Order> Orders { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
