using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppMVC.Models;

public class CartItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int CartId { get; set; }
    public Cart Cart { get; set; }

    public int ProductId;
    public Product Product { get; set; }

    public int Quantity { get; set; }
}
