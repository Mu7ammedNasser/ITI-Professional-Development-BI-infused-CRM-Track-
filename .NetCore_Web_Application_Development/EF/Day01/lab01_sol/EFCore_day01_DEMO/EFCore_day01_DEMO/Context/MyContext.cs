using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_day01_DEMO.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_day01_DEMO.Context
{
    internal class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-DH7T4Q7;DataBase=EF_Day01_Demo;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseLazyLoadingProxies().
                UseSqlServer(connectionString);
        }

        //fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // important when use identity

            modelBuilder.Entity<Employee>()
                        .HasKey(e => e.E_Id);

            modelBuilder.Entity<Employee>().Property(e => e.Name).HasMaxLength(20);

            modelBuilder.Entity<Department>().HasKey(d => d.DeptId);
        }

        // 1- class map tp table into db
        // 2- Local Container 
        public virtual DbSet<Employee> employees { get; set; }

        /// if ef runtime found that the next line do not exist will generate it automatic 
        /// as he found the relation btw Emp and dept so he will assume that u forget it and generate it automatic
        /// note if it is as entity with no relation with any another entity will not be added in db.

        /// best practise to write dbset  Explicitly not depened on the automatic generation 
        /// and when you start searching found local container to use it for add and delete and insert and so on 


        public virtual DbSet<Department> Departments { get; set; }
    }
}
