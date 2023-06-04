using CommandLine;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Repository.IRepository;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Repository.IRepository;

namespace WebAppMVC.Repository
{
    public class CartRepository<T> : ICartRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbset;
        public CartRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public static Cart GetCart(IServiceProvider services)
        {
            return null;
        }
        public async Task<CartItem> GetCartItem(Product product)
        {
            var item = await _context.CartItems.FirstOrDefaultAsync(ci => ci.Product.Id == product.Id);
            return item;
        }
        public async Task<CartItem> AddToCart(Product product, int quantity)
        {
            var cartItem = await GetCartItem(product);
            if (cartItem == null)
            {
                cartItem = new CartItem 
                { 
                    Product = product,
                    Quantity = quantity,
                };
                _context.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity += quantity;
            }


            await _context.SaveChangesAsync();
            return null;
        }
        public async Task<CartItem> ReduceQuantity(Product product)
        {
            var cartItem = await GetCartItem(product);
            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    --cartItem.Quantity; 
                }
                else
                {
                     _context.CartItems.Remove(cartItem);
                }
            }
            await _context.SaveChangesAsync();
            return null;
        }
        public async Task<CartItem> IncreaseQuantity(Product product)
        {
            var cartItem = await GetCartItem(product);
            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    ++cartItem.Quantity;
                }
                else
                {
                    await _context.CartItems.AddAsync(cartItem);
                }
            }
            await _context.SaveChangesAsync();
            return null;
        }

    }
}
