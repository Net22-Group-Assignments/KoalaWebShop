using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebAppAPI.Models.KoalaCustomerDto
{
    public class KoalaCustomerApiDto
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
