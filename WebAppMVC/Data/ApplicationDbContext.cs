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
        }
    }
}