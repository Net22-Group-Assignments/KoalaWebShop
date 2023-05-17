using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models.Dto
{
    public class KoalaCustomerDto
    {
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
