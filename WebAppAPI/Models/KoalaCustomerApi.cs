using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class KoalaCustomerApi : IdentityUser<int>
    {
        [Required]
        [StringLength(40)]
        public string FirstMidName { get; set; }
        [Required]
        [StringLength(40)]
        public string LastName { get; set; }
        [Required]
        public DateTime RegisteredAt { get; set; }
        [Required]
        public DateTime LastLogin { get; set; }
    }
}
