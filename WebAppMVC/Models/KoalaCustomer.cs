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
        [Required]
        [StringLength(50)]
        public string Adress { get; set; }
        [Required]
        public DateTime RegisteredAt { get; set; }

        ICollection<Order> Orders { get; set; }
        ICollection<Review> Reviews { get; set; }
    
    }
}
