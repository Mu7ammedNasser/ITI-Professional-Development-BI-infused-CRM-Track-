using Microsoft.EntityFrameworkCore;
using MVC_day04_lab.Models;

namespace MVC_day04_lab.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        /*========================================*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DH7T4Q7;DataBase=MVC_DAY04_Lab;Trusted_Connection=true;TrustServerCertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region data seading
            var categories = new List<Category>()
            {
                new Category(){Id=1,Name="Electronics"},
                new Category(){Id=2,Name="Clothes"},
                new Category(){Id=3,Name="Food"},
            };

            var products = new List<Product>()
            {
                new Product(){Id=1,Name="TV",Price=5000,Description="Smart TV",Count=10,CategoryId=1},
                new Product(){Id=2,Name="Laptop",Price=10000,Description="Gaming Laptop",Count=5,CategoryId=1},
                new Product(){Id=3,Name="Shirt",Price=200,Description="Cotton Shirt",Count=50,CategoryId=2},
                new Product(){Id=4,Name="Pants",Price=300,Description="Jeans Pants",Count=30,CategoryId=2},
                new Product(){Id=5,Name="Bread",Price=5,Description="Whole Wheat Bread",Count=100,CategoryId=3},
                new Product(){Id=6,Name="Milk",Price=3,Description="Low Fat Milk",Count=200,CategoryId=3},
            };

            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Product>().HasData(products);
            #endregion


            #region External Configuration (Fluent API)
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
            //"Go to this project (assembly), find all configuration classes that implement
            //IEntityTypeConfiguration<>, and apply them automatically."
            //* This is a convenient way to apply all configurations without having to call each one individually.
            //* Get the current project’s compiled file.

            #endregion




            base.OnModelCreating(modelBuilder);


        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
