using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models;

namespace WebAppMVC.Services
{
    public class OrderService
    {
        private readonly ApplicationDbContext _db;
        public OrderService(ApplicationDbContext context)
        {
            _db = context;
        }
        private async Task<Order> InitializeOrder(KoalaCustomer customer)
        {
            var order = await _db.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(p => p.Product)
                .FirstOrDefaultAsync(c => c.Customer.Id == customer.Id);
            //if (order is null)
            //{order = new Order

            //}

            return order;
        }
    }
}
