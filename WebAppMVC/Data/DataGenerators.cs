using Microsoft.AspNetCore.Identity;
using SimpleBase;
using WebAppMVC.Models;

namespace WebAppMVC.Data;

public class DataGenerators
{
    private static readonly string passwordHash = new PasswordHasher<KoalaCustomer>().HashPassword(
        null,
        "secret"
    );
    private static byte[] bytes = new byte[32];

    private static int idPool = 1;
    private static int productIdPool = 1;
    private static int reviewIdPool = 1;
    private static int categoryIdPool = 1;

    internal static KoalaCustomer NewCustomer(
        string email,
        string firstMidName,
        string lastName,
        string adress
    )
    {
        Random.Shared.NextBytes(bytes);
        var customer = new KoalaCustomer()
        {
            Id = idPool++,
            UserName = email,
            FirstMidName = firstMidName,
            LastName = lastName,
            Adress = adress,
            NormalizedUserName = email.ToUpper(),
            Email = email,
            NormalizedEmail = email.ToUpper(),
            PhoneNumber = null,
            EmailConfirmed = true,
            PasswordHash = passwordHash,
            SecurityStamp = Base32.Rfc4648.Encode(bytes),
            PhoneNumberConfirmed = false,
            TwoFactorEnabled = false,
            LockoutEnd = null,
            LockoutEnabled = true,
            AccessFailedCount = 0,
            RegisteredAt = DateTime.Now,
        };

        return customer;
    }

    internal static Product NewProduct(
        string title,
        decimal price,
        int quantity,
        string content,
        Category category = null,
        string imageUrl = null
    )
    {
        var product = new Product()
        {
            ProductId = productIdPool++,
            Title = title,
            Price = price,
            Quantity = quantity,
            Content = content,
            ImgURL = imageUrl
        };

        if (category is not null)
        {
            product.FkCategory = category.CategoryId;
        }

        return product;
    }

    internal static Review NewProductReview(
        int fk_productid,
        string title,
        int rating,
        string Content
    )
    {
        var productReview = new Review()
        {
            ProductReviewId = reviewIdPool++,
            FK_ProductId = fk_productid,
            Title = title,
            Content = Content
        };
        return productReview;
    }

    internal static Category NewCategory(string title, string content)
    {
        var category = new Category()
        {
            CategoryId = categoryIdPool++,
            Title = title,
            Content = content
        };
        return category;
    }
}
