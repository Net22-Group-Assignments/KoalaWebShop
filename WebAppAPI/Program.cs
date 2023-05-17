namespace WebAppAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            //MappingSettings
            builder.Services.AddScoped<IRepository<KoalaCustomerApi>, Repository<KoalaCustomerApiDto>>();
            builder.Services.AddScoped<IRepository<KoalaCustomerApi>, Repository<KoalaCustomerApiDto>>();
            builder.Services.AddAutoMapper(typeof(WebAppAPI.MappingConfig)); //Automapper required for mapper to function
            //EndofMapping

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}