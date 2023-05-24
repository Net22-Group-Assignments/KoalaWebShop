using Bogus;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebAppMVC.Models;

namespace WebAppMVC.Data;

public class DataFaker
{
    private static readonly int[] _discountLevels = { 5, 10, 25, 50 };

    private static readonly string[] _categories =
    {
        "Books",
        "Movies",
        "Music",
        "Games",
        "Electronics",
        "Computers",
        "Home",
        "Garden",
        "Tools",
        "Grocery",
        "Health",
        "Beauty",
        "Toys",
        "Kids",
        "Baby",
        "Clothing",
        "Shoes",
        "Jewelery",
        "Sports",
        "Outdoors",
        "Automotive",
        "Industrial"
    };

    private readonly ApplicationDbContext _dbContext;
    private readonly ILogger<DataFaker> _logger;
    public IReadOnlyCollection<Category> Categories;
    public IReadOnlyCollection<Product> Products;

    // If used in static context with Migrations
    public DataFaker(int nProducts, int nCategories)
    {
        Categories = GenerateCategories(databaseGeneratedIdentity: false);
        Products = GenerateProducts(
            amount: nProducts,
            categories: Categories,
            databaseGeneratedIdentity: false
        );
    }

    // If used as injected service
    public DataFaker(ApplicationDbContext dbContext, ILogger<DataFaker> logger)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    private static IReadOnlyCollection<Category> GenerateCategories(
        bool databaseGeneratedIdentity = true
    )
    {
        var categoryIds = 1;
        var categoryIndex = 0;

        var categoryFaker = new Faker<Category>().Rules(
            (
                (faker, category) =>
                {
                    category.Title = _categories[categoryIndex++];
                    category.Content = faker.Lorem.Sentence();
                }
            )
        );

        if (!databaseGeneratedIdentity)
        {
            categoryFaker = categoryFaker.RuleFor(category => category.CategoryId, categoryIds++);
        }

        return Enumerable
            .Range(1, _categories.Length)
            .Select(i => SeedRow(categoryFaker, i))
            .ToList();
    }

    private static IReadOnlyCollection<Product> GenerateProducts(
        IEnumerable<Category> categories,
        int amount = 100,
        float discountChance = 0.25f,
        int maxReviews = 5,
        int maxQuantity = 100,
        bool databaseGeneratedIdentity = true
    )
    {
        var productIds = 1;

        var productFaker = new Faker<Product>().Rules(
            (
                (faker, product) =>
                {
                    productIds++;
                    product.Title = faker.Commerce.ProductName();
                    product.Category = faker.PickRandom(categories);
                    product.Price = decimal.Parse(faker.Commerce.Price());
                    product.Content = faker.Commerce.ProductDescription();
                    // Discounted or not?
                    if (faker.Random.Float() <= discountChance)
                    {
                        product.Discount = 100M / faker.PickRandom(_discountLevels);
                    }

                    product.Quantity = faker.Random.Number(maxQuantity);
                    product.ImgURL = faker.Image.PicsumUrl();

                    if (faker.Random.Bool())
                    {
                        product.Reviews =
                            GenerateReviews(
                                faker.Random.Number(maxReviews),
                                productSeed: productIds
                            ) as ICollection<Review>;
                    }
                }
            )
        );

        if (!databaseGeneratedIdentity)
        {
            productFaker = productFaker.RuleFor(product => product.ProductId, productIds);
        }

        return Enumerable.Range(1, amount).Select(i => SeedRow(productFaker, i)).ToList();
    }

    private static IReadOnlyCollection<Review> GenerateReviews(
        int amount,
        int productSeed = 0,
        bool databaseGeneratedIdentity = true
    )
    {
        var reviewIds = 1;

        var reviewFaker = new Faker<Review>().Rules(
            (
                (faker, review) =>
                {
                    review.Title = faker.Commerce.ProductAdjective();
                    review.Content = faker.Rant.Review();
                }
            )
        );

        if (!databaseGeneratedIdentity)
        {
            reviewFaker = reviewFaker.RuleFor(review => review.ProductReviewId, reviewIds++);
        }

        return Enumerable
            .Range(1, amount)
            .Select(i => SeedRow(reviewFaker, i + productSeed))
            .ToList();
    }

    /**
     * Helper function for deterministic seed.
     */
    private static T SeedRow<T>(Faker<T> faker, int rowId)
        where T : class
    {
        var recordRow = faker.UseSeed(rowId).Generate();
        return recordRow;
    }

    public void Seed(bool dryRun, int nProducts)
    {
        Categories = GenerateCategories();
        Products = GenerateProducts(amount: nProducts, categories: Categories);

        if (dryRun)
        {
            _logger.LogInformation("Categories: {Categories}", Categories.Dump());
            _logger.LogInformation("Products: {Products}", Products.Dump());
        }
        else
        {
            _dbContext.AddRange(Categories);
            _dbContext.AddRange(Products);
            int recordsSaved = _dbContext.SaveChanges();
            _logger.LogInformation("Database updated with {RecordsSaved} rows", recordsSaved);
        }

        _logger.LogInformation("Generated {N} categories", Categories.Count);
        _logger.LogInformation("Generated {N} products", Products.Count);
    }
}
