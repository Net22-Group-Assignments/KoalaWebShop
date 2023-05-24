using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Models;
using WebAppMVC.Models.ViewModels;

namespace WebAppMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<KoalaCustomer, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        //public DbSet<Admin> Admins { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<KoalaCustomer> KoalaCustomers { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<KoalaCustomer>()
                .HasData(
                    DataGenerators.NewCustomer(
                        email: "jon.westman@mail.com",
                        firstMidName: "Jon",
                        lastName: "Westman",
                        adress: "Fakestreet101"
                    ),
                    DataGenerators.NewCustomer(
                        email: "bjorn.agnemo@mail.com",
                        firstMidName: "Björn",
                        lastName: "Agnemo",
                        adress: "Fakestreet102"
                    ),
                    DataGenerators.NewCustomer(
                        email: "Oskar.Ahling@mail.com",
                        firstMidName: "Oskar",
                        lastName: "Åhling",
                        adress: "Fakestreet103"
                    ),
                    DataGenerators.NewCustomer(
                        email: "Reidar.Nilsen@mail.com",
                        firstMidName: "Reidar",
                        lastName: "Nilsen",
                        adress: "Fakestreet104"
                    ),
                    DataGenerators.NewCustomer(
                        email: "Ina.Nilsson@mail.com",
                        firstMidName: "Ina",
                        lastName: "Nilsson",
                        adress: "Fakestreet105"
                    ),
                    DataGenerators.NewCustomer(
                        email: "Martin.Petersson@mail.com",
                        firstMidName: "Martin",
                        lastName: "Petersson",
                        adress: "Fakestreet106"
                    ),
                    DataGenerators.NewCustomer(
                        email: "Steve.Carell@mail.com",
                        firstMidName: "Steve",
                        lastName: "Carell",
                        adress: "Fakestreet107"
                    ),
                    DataGenerators.NewCustomer(
                        email: "Grogu.Mandelorian@mail.com",
                        firstMidName: "Grogu",
                        lastName: "Mandelorian",
                        adress: "Fakestreet108"
                    ),
                    DataGenerators.NewCustomer(
                        email: "Lotta.Svensson@mail.com",
                        firstMidName: "Lotta",
                        lastName: "Svensson",
                        adress: "Fakestreet109"
                    ),
                    DataGenerators.NewCustomer(
                        email: "Emilia.Ristersson@mail.com",
                        firstMidName: "Emilia",
                        lastName: "Ristersson",
                        adress: "Fakestreet110"
                    )
                );

            var sportCategory = DataGenerators.NewCategory(
                title: "Sport",
                content: "Everything used in sports can be found in this category"
            );

            var fashionCategory = DataGenerators.NewCategory(
                title: "Fashion",
                content: "Everything used in fashion can be found in this category"
            );

            var outdoorCategory = DataGenerators.NewCategory(
                title: "Outdoor life",
                content: "Everything used in outdoor life can be found in this category"
            );

            var electronicCategory = DataGenerators.NewCategory(
                title: "Electronic",
                content: "Everything used in Electronic can be found in this category"
            );

            modelBuilder
                .Entity<Category>()
                .HasData(sportCategory, fashionCategory, outdoorCategory, electronicCategory);

            modelBuilder
                .Entity<Product>()
                .HasData(
                    DataGenerators.NewProduct(
                        title: "Jacket",
                        price: 599,
                        quantity: 5,
                        content: "A nice jacket",
                        category: fashionCategory
                    ),
                    DataGenerators.NewProduct(
                        title: "Pants",
                        price: 499,
                        quantity: 6,
                        content: "So-so pants",
                        category: fashionCategory
                    ),
                    DataGenerators.NewProduct(
                        title: "HockeyStick",
                        price: 1299,
                        quantity: 11,
                        content: "Stick it to the (goal)-man",
                        category: sportCategory
                    ),
                    DataGenerators.NewProduct(
                        title: "Football",
                        price: 399,
                        quantity: 12,
                        content: "In sweden we say joxa med trasan",
                        category: sportCategory
                    ),
                    DataGenerators.NewProduct(
                        title: "Snowboard",
                        price: 2099,
                        quantity: 10,
                        content: "Rad!!!",
                        category: outdoorCategory
                    ),
                    DataGenerators.NewProduct(
                        title: "HeadPhones",
                        price: 1199,
                        quantity: 5,
                        content: "Tinnitus-inducing guaranteed",
                        category: electronicCategory
                    ),
                    DataGenerators.NewProduct(
                        title: "GamingMouse",
                        price: 649,
                        quantity: 3,
                        content: "5 giga-dpi and infinite APM",
                        category: electronicCategory
                    ),
                    DataGenerators.NewProduct(
                        title: "Mechanicle Keyboard",
                        price: 1799,
                        quantity: 7,
                        content: "Clickity-Clackity!",
                        category: electronicCategory
                    ),
                    DataGenerators.NewProduct(
                        title: "ComputerScreen",
                        price: 2199,
                        quantity: 2,
                        content: "100 lbs of CRT",
                        category: electronicCategory
                    ),
                    DataGenerators.NewProduct(
                        title: "MousePad",
                        price: 99,
                        quantity: 15,
                        content: "Signed by Ninja",
                        category: electronicCategory
                    )
                );
        }
    }
}
