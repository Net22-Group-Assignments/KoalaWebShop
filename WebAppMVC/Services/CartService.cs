using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Data;
using WebAppMVC.Models;

namespace WebAppMVC.Services;

public class CartService
{
    private readonly ApplicationDbContext _db;

    public CartService(ApplicationDbContext db)
    {
        _db = db;
    }

    private async Task<Cart> InitializeCart(KoalaCustomer customer)
    {
        var cart = await _db.Carts
            .Include(c => c.CartItems)
            .ThenInclude(ci => ci.Product)
            .FirstOrDefaultAsync(c => c.Customer.Id == customer.Id);
        if (cart is null)
        {
            cart = new Cart { Customer = customer, CartItems = new List<CartItem>() };
            _db.Carts.Add(cart);
            await _db.SaveChangesAsync();
        }

        return cart;
    }

    public async Task AddToCart(int productId, int quantity, KoalaCustomer customer)
    {
        var cart = await InitializeCart(customer);

        var cartItem = cart.CartItems.FirstOrDefault(p => p.ProductId == productId);

        if (cartItem is null)
        {
            var product = await _db.Products.FirstOrDefaultAsync(p => p.Id == productId);

            cartItem = new CartItem
            {
                Cart = cart,
                Product = product,
                Quantity = quantity
            };

            cart.CartItems.Add(cartItem);
        }
        else
        {
            cartItem.Quantity += quantity;
        }

        await _db.SaveChangesAsync();
    }

    public async Task ReduceQuantity(int cartItemId, KoalaCustomer customer)
    {
        var cart = await InitializeCart(customer);

        var cartItem = cart.CartItems.FirstOrDefault(c => c.Id == cartItemId);

        if (cartItem != null)
        {
            if (cartItem.Quantity > 1)
            {
                cartItem.Quantity--;
            }
            else
            {
                cart.CartItems.Remove(cartItem);
            }
        }
        await _db.SaveChangesAsync();
    }

    public async Task RemoveFromCart(int cartItemId, KoalaCustomer customer)
    {
        var cart = await InitializeCart(customer);

        var cartItem = cart.CartItems.FirstOrDefault(c => c.Id == cartItemId);

        if (cartItem != null)
        {
            cart.CartItems.Remove(cartItem);
        }
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<CartItem>> GetAllCartItems(KoalaCustomer customer)
    {
        var cart = await InitializeCart(customer);

        return cart.CartItems;
    }
}
