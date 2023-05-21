using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
	public class Currency
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CurrencyId { get; set; }
        public string Base { get; set; }
		public decimal Rate { get; set; }
    }
}
