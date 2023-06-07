using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models.CurrencyModel
{
	public class Currency
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CurrencyId { get; set; }
        public string success { get; set; }
        public int timestamp { get; set; }
        public string @base { get; set; }
		public string date { get; set; }
		public Rates rates { get; set; }
    }


}
