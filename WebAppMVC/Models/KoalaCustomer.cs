using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
    public class KoalaCustomer : IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string KoalaCustomerId { get; set; }
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
        //[StringLength(500)]
        //public string Profile { get; set; }
        //[ForeignKey(nameof(Admins))]
        //public int FK_AdminId { get; set; }
        //public Admin Admins { get; set; }
    }
}
