using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Diagnostics.Eventing.Reader;
using Microsoft.EntityFrameworkCore;

namespace WebAppMVC.Models.CurrencyModel
{
	public class Rates
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RatesId { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        [Precision(18,6)]
        public decimal SEK { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        [Precision(18, 6)]
        public decimal USD { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        [Precision(18, 6)]
        public decimal EUR { get; set; }

	}
}
