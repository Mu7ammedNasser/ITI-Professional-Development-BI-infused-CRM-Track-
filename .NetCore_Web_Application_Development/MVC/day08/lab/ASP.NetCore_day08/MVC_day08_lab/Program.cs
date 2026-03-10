using Microsoft.EntityFrameworkCore;
using MVC_day04_lab.Data.Context;
using MVC_day04_lab.Repositories.CategoryRepository;
using MVC_day04_lab.Repositories.ProductRepository;

namespace MVC_day04_lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /// Create a new instance of the WebApplicationBuilder class,
            /// which is used to configure and build the web application

            /// Create and configure the foundation of ASP.NET Core MVC application
            /// Create a WebApplicationBuilder Object
            /// Builder is responsible for configuring application before it is built and run
            /// Sets up default congiguration, logging, and dependency injection services
            /// Load Settings from appsettings.json and environment variables
            /// Configure Dependency Injection (DI) container
            /// Configure web server (Kestrel) and other services
            /// Prepare the application to handle HTTP requests and responses
            /// Prepare middleware pipeline and routing for the application
            var builder = WebApplication.CreateBuilder(args);



            #region Containers
            // Add services to the container. "Register Services"
            // 1- Built in services and already configured (in IOC Container) by the framework "IConfiguration",
            // 2- Built in services but not configured by the framework "AddSession", "AddDbContext"
            // 3- Custom services created by the developer "IPrint", "PrintV02"
            builder.Services.AddControllersWithViews();

            // create a scoped service for the ApplicationContext class, which is a DbContext used for database operations.
            builder.Services.AddDbContext<ApplicationContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("ASPNETDAY08"))
                );

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

            var app = builder.Build();
            #endregion

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
