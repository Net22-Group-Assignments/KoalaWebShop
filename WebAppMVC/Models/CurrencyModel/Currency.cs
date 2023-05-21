using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAppMVC.Models.CurrencyModel;

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


}
