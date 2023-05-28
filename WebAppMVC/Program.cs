using CommandLine;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using WebAppAPI;
using WebAppAPI.Repository;
using WebAppAPI.Repository.IRepository;
using WebAppMVC.Data;
using WebAppMVC.Models;
using WebAppMVC.Services;

var seedData = false;
var dryRun = false;
var nProducts = 0;

// Intercepts any added arguments on commandline
Parser.Default
    .ParseArguments<ParserOptions>(args)
    .WithParsed(o =>
    {
        if (o.SeedData)
        {
            seedData = o.SeedData;
            dryRun = o.Dry;
            nProducts = o.NProducts;
        }
    });

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(connectionString)
);
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//Pre-load Data IRepository
builder.Services.AddScoped<IRepository<KoalaCustomer>, Repository<KoalaCustomer>>();
builder.Services.AddScoped<IRepository<Product>, Repository<Product>>();
builder.Services.AddScoped<IRepository<Review>, Repository<Review>>();
//AddServices
builder.Services.AddScoped<CartService>();

//End of Pre-load data

builder.Services
    .AddDefaultIdentity<KoalaCustomer>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 6;
        options.Password.RequiredUniqueChars = 0;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingConfig)); //Automapper required for mapper to function

if (seedData)
{
    builder.Services.AddTransient<DataFaker>();
}

var app = builder.Build();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "api";
});

//Seed Data
if (seedData)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using var scope = scopedFactory.CreateScope();
    var service = scope.ServiceProvider.GetRequiredService<DataFaker>();
    service.Seed(dryRun: dryRun, nProducts: nProducts);
    Environment.Exit(0);
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "api";
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

public class ParserOptions
{
    [Option(
        "seed",
        Required = false,
        Default = false,
        HelpText = "Seed the datebase with bogus products"
    )]
    public bool SeedData { get; set; }

    [Option("products", Required = false, Default = 0, HelpText = "Number of products to generate")]
    public int NProducts { get; set; }

    [Option(
        "dry",
        Required = false,
        Default = false,
        HelpText = "Dry run with logging. No data will be saved"
    )]
    public bool Dry { get; set; }
}
