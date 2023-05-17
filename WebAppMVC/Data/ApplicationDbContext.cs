using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Models;

namespace WebAppMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<KoalaCustomer, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<KoalaCustomer> KoalaCustomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<KoalaCustomer>().HasData(

                DataGenerators.NewCustomer(email: "jon.westman@mail.com", firstMidName: "Jon", lastName: "Westman"),
                DataGenerators.NewCustomer(email: "bjorn.agnemo@mail.com", firstMidName: "Björn", lastName: "Agnemo"),
                DataGenerators.NewCustomer(email: "Oskar.Ahling@mail.com", firstMidName: "Oskar", lastName: "Åhling"),
                DataGenerators.NewCustomer(email: "Reidar.Nilsen@mail.com", firstMidName: "Reidar", lastName: "Nilsen"),
                DataGenerators.NewCustomer(email: "Ina.Nilsson@mail.com", firstMidName: "Ina", lastName: "Nilsson"),
                DataGenerators.NewCustomer(email: "Martin.Petersson@mail.com", firstMidName: "Martin", lastName: "Petersson"),
                DataGenerators.NewCustomer(email: "Steve.Carell@mail.com", firstMidName: "Steve", lastName: "Carell"),
                DataGenerators.NewCustomer(email: "Grogu.Mandelorian@mail.com", firstMidName: "Grogu", lastName: "Mandelorian"),
                DataGenerators.NewCustomer(email: "Lotta.Svensson@mail.com", firstMidName: "Lotta", lastName: "Svensson"),
                DataGenerators.NewCustomer(email: "Emilia.Ristersson@mail.com", firstMidName: "Emilia", lastName: "Ristersson")
            );
            modelBuilder.Entity<Product>().HasData(
                DataGenerators.NewProduct(title: "Jacket", price: 599, discount: 0, summary:"599", quantity: 1),
                DataGenerators.NewProduct(title: "Pants", price: 499, discount: 50, summary: "449", quantity: 1),
                DataGenerators.NewProduct(title: "HockeyStick", price: 1299, discount: 400, summary: "899", quantity: 1)
                );
            modelBuilder.Entity<ProductReview>().HasData(
                DataGenerators.NewProductReview(fk_productid: 5, parentId: 4, title: "HockeyClub", rating: 9,Content: "I have used this for 10 years and still going strong 9/10")
                );
        }
    }
}