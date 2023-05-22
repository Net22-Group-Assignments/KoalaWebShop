using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models.CurrencyModel
{
	public class Rates
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RatesId { get; set; }
		public decimal SEK { get; set; }
		public decimal USD { get; set; }
		public decimal EUR { get; set; }

	}
}
