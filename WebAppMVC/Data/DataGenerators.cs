using Microsoft.AspNetCore.Identity;
using SimpleBase;
using WebAppMVC.Models;

namespace WebAppMVC.Data;

public class DataGenerators
{
    private static readonly string passwordHash =
        new PasswordHasher<KoalaCustomer>().HashPassword(null, "secret");
    private static byte[] bytes = new byte[32];
    
    private static int idPool = 1;
    private static int productIdPool = 5;
    private static int reviewIdPool = 1;

    internal static KoalaCustomer NewCustomer(string email, string firstMidName, string lastName)
    { 
        Random.Shared.NextBytes(bytes);
        var customer = new KoalaCustomer()
        {
            Id = idPool++,
            UserName = email,
            FirstMidName = firstMidName,
            LastName = lastName,
            NormalizedUserName = email.ToUpper(),
            Email = email,
            NormalizedEmail = email.ToUpper(),
            EmailConfirmed = true,
            PasswordHash = passwordHash,
            SecurityStamp = Base32.Rfc4648.Encode(bytes),
            PhoneNumber = null,
            PhoneNumberConfirmed = false,
            TwoFactorEnabled = false,
            LockoutEnd = null,
            LockoutEnabled = true,
            AccessFailedCount = 0,
            RegisteredAt = DateTime.Now,
            LastLogin = DateTime.Today
        };

        return customer;
    }
    internal static Product NewProduct(string title, decimal price, decimal discount, string summary, int quantity)
    {
        var product = new Product()
        {
            ProductId = productIdPool++,
            Title = title,
            Price= price,
            Discount=discount,
            Summary=summary,
            Quantity = quantity,
            CreatedAt= DateTime.Today,
            UpdatedAt= DateTime.Now
        };
        return product;
    }
    internal static ProductReview NewProductReview(int fk_productid, int parentId, string title, int rating, string Content)
    {
        var productReview = new ProductReview()
        {
            ProductReviewId= reviewIdPool++,
            FK_ProductId= fk_productid,
            ParentId= parentId,
            Title= title,
            Rating= rating,
            Content= Content
        };
        return productReview;
    }
}