using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models
{
	public class Currency
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CurrencyId { get; set; }
		public string Base { get; set; } = "SEK";
		public string date { get; set; }
		public Rates rates { get; set; }
    }

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
