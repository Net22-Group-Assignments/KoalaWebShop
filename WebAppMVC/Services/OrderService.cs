using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models;

namespace WebAppMVC.Services
{
    public class OrderService
    {
        private readonly ApplicationDbContext _db;
        public OrderService(ApplicationDbContext context, HttpContextAccessor contextAccessor, UserManager<KoalaCustomer> userManager, CartService cartService)
        {
            _db = context;

        }
        private async Task<Order> InitializeOrder()
        {
            var order = await _db.Orders
         .Include(c => c.OrderItems)
         .ThenInclude(ci => ci.Product)
         .FirstOrDefaultAsync();
            return order;
        }
        public async Task<IEnumerable<OrderItem>> GetAllOrderItems()
        {
            var order = await InitializeOrder();

            return order.OrderItems;
        }
    }
}


