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
                        category: fashionCategory,
                        imageUrl: "https://americasuits.com/image/cache/wp/gj/resident-evil-4-leon-kennedy-jacket/resident-evil-4-leon-kennedy-jacket-1100x1100h.webp"
                    ),
                    DataGenerators.NewProduct(
                        title: "Pants",
                        price: 499,
                        quantity: 6,
                        content: "So-so pants",
                        category: fashionCategory,
                        imageUrl: "https://upload.wikimedia.org/wikipedia/commons/d/da/Trousers-colourisolated.jpg"
                    ),
                    DataGenerators.NewProduct(
                        title: "HockeyStick",
                        price: 1299,
                        quantity: 11,
                        content: "Stick it to the (goal)-man",
                        category: sportCategory,
                        imageUrl: "https://4.bp.blogspot.com/-WHe4vnmCBkQ/V__MkZOfOPI/AAAAAAAAD-0/17GkfCHqXZ8XArU_uSJgdk4h9TV-kFFnACLcB/s1600/titantsm99.jpg"
                    ),
                    DataGenerators.NewProduct(
                        title: "Football",
                        price: 399,
                        quantity: 12,
                        content: "In sweden we say joxa med trasan",
                        category: sportCategory,
                        imageUrl: "https://www.thesoccerstore.co.uk/wp-content/uploads/Old-Mitre-Football.jpg"
                    ),
                    DataGenerators.NewProduct(
                        title: "Snowboard",
                        price: 2099,
                        quantity: 10,
                        content: "Rad!!!",
                        category: outdoorCategory,
                        imageUrl: "https://th-thumbnailer.cdn-si-edu.com/nrlGXEDS63adOwlk-QTZeLM8yw4=/fit-in/1072x0/filters:focal(585x830:586x831)/https://tf-cmsv2-smithsonianmag-media.s3.amazonaws.com/filer_public/56/5a/565a1afc-62ae-462e-a5f3-1ba4a65b68c1/janfeb2022_e04_prologue.jpg"
                    ),
                    DataGenerators.NewProduct(
                        title: "HeadPhones",
                        price: 1199,
                        quantity: 5,
                        content: "Tinnitus-inducing guaranteed",
                        category: electronicCategory,
                        imageUrl: "https://flashbak.com/wp-content/uploads/2018/02/1975-Sears-Wishbook2017-11-25-20_45_53-1280x766.jpg"
                    ),
                    DataGenerators.NewProduct(
                        title: "GamingMouse",
                        price: 649,
                        quantity: 3,
                        content: "5 giga-dpi and infinite APM",
                        category: electronicCategory,
                        imageUrl: "https://i.pcmag.com/imagery/articles/07kXnVL7WadXYRlXGpKwS6x-1.jpg"
                    ),
                    DataGenerators.NewProduct(
                        title: "Mechanicle Keyboard",
                        price: 1799,
                        quantity: 7,
                        content: "Clickity-Clackity!",
                        category: electronicCategory,
                        imageUrl: "https://upload.wikimedia.org/wikipedia/commons/4/47/Space-cadet.jpg"
                    ),
                    DataGenerators.NewProduct(
                        title: "ComputerScreen",
                        price: 2199,
                        quantity: 2,
                        content: "100 lbs of CRT",
                        category: electronicCategory,
                        imageUrl: "https://archive.mith.umd.edu/vintage-computers/archive/fullsize/img_1417_32dd1d0df0.jpg"
                    ),
                    DataGenerators.NewProduct(
                        title: "MousePad",
                        price: 99,
                        quantity: 15,
                        content: "Signed by Ninja",
                        category: electronicCategory,
                        imageUrl: "https://i3.cpcache.com/merchandise/3_750x750_Front_Color-NA.jpg?AttributeValue=NA&c=False&OrientationNo=1&region={%22name%22:%22FrontCenter%22,%22width%22:8,%22height%22:8,%22alignment%22:%22MiddleCenter%22,%22orientation%22:1,%22dpi%22:100,%22crop_x%22:0,%22crop_y%22:0,%22crop_h%22:800,%22crop_w%22:800,%22scale%22:0,%22template%22:{%22id%22:20445850,%22params%22:{}}}&cid=PUartJBjiF%2fyg4FdKqiggQ%3d%3d+%7c%7c+Bo%2fDnDkn7FICaYkBchZRUQ%3d%3d&ProductNo=145782874"
                    )
                );
        }
    }
}
