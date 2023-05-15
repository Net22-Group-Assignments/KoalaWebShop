using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Models;

namespace WebAppMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<KoalaCustomer>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Admin> Admins { get; set; }
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
            
            modelBuilder.Entity<KoalaCustomer>().HasData(
                
                new KoalaCustomer
                {
                    KoalaCustomerId = "1",
                    FirstMidName = "Jon",
                    LastName = "Westman",
                    RegisteredAt= DateTime.Now,
                    LastLogin= DateTime.Today,

                },
                new KoalaCustomer
                {
                    
                    KoalaCustomerId = "2",
                    FirstMidName = "Björn",
                    LastName = "Agnemo",
                    RegisteredAt = DateTime.Now,
                    LastLogin = DateTime.Today,

                }, 
                new KoalaCustomer
                {
                    KoalaCustomerId = "3",
                    FirstMidName = "Oskar",
                    LastName = "Åhling",
                    RegisteredAt = DateTime.Now,
                    LastLogin = DateTime.Today,
                },
                new KoalaCustomer
                {
                    KoalaCustomerId = "4",
                    FirstMidName = "Reidar",
                    LastName = "Nilsen",
                    RegisteredAt = DateTime.Now,
                    LastLogin = DateTime.Today,

                }, 
                new KoalaCustomer
                {
                    KoalaCustomerId = "5",
                    FirstMidName = "Ina",
                    LastName = "Nilsson",
                    RegisteredAt = DateTime.Now,
                    LastLogin = DateTime.Today,
                }, 
                new KoalaCustomer
                {
                    KoalaCustomerId = "6",
                    FirstMidName = "Martin",
                    LastName = "Petersson",
                    RegisteredAt = DateTime.Now,
                    LastLogin = DateTime.Today,
                }, 
                new KoalaCustomer
                {
                    KoalaCustomerId = "7",
                    FirstMidName = "Steve",
                    LastName = "Carell",
                    RegisteredAt = DateTime.Now,
                    LastLogin = DateTime.Today,
                },
                new KoalaCustomer
                {
                    KoalaCustomerId = "8",
                    FirstMidName = "Grogu",
                    LastName = "Mandalorian",
                    RegisteredAt = DateTime.Now,
                    LastLogin = DateTime.Today,
                },
                 new KoalaCustomer
                 {
                     KoalaCustomerId = "9",
                     FirstMidName = "Lotta",
                     LastName = "Svensson",
                     RegisteredAt = DateTime.Now,
                     LastLogin = DateTime.Today,
                 }, 
                 new KoalaCustomer
                 {
                     KoalaCustomerId = "10",
                     FirstMidName = "Emilia",
                     LastName = "Ristersson",
                     RegisteredAt = DateTime.Now,
                     LastLogin = DateTime.Today,
                 });
        }

    }


}