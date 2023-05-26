using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models;

namespace WebAppMVC.Services
{
    public class CartService
    {
        private readonly ApplicationDbContext _db;

        public CartService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Cart> InitializeCart(string userName)
        {
            KoalaCustomer Customer = await _db.KoalaCustomers.FirstOrDefaultAsync(u=>u.UserName.Equals(userName));
            if (Customer != null) 
            {
                Cart cart = new Cart();
                cart.KoalaId = Customer;
                _db.Carts.Add(cart);
                await _db.SaveChangesAsync();
            }
            if (Customer == null)
            {
                ExceptionHandlerOptions.ReferenceEquals(Customer, null);
            }
            
            return null;
        } 
    }
}
