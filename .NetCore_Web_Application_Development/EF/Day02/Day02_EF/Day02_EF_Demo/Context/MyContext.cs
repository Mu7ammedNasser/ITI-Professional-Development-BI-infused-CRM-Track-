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

        public MyContext() :base() { }

        public MyContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-DH7T4Q7;DataBase=EF_Day02_Migration_Demo;Trusted_Connection=true;TrustServerCertificate=true";
            //optionsBuilder.UseLazyLoadingProxies().
                optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // important when use identity

            modelBuilder.Entity<Employee>()
                        .HasKey(e => e.E_Id);
            modelBuilder.Entity<Employee>().Property(e => e.Name).HasMaxLength(20);
            modelBuilder.Entity<Department>().HasKey(d => d.DeptId);

            // one to many configuration 
            //modelBuilder.Entity<Employee>()
            //            .HasOne(e => e.Department)
            //            .WithMany(e => e.Employees)
            //            .HasForeignKey(e => e.DepartmentID)
            //            .IsRequired()
            //            .OnDelete(DeleteBehavior.Restrict);

        }
 
        public virtual DbSet<Employee> employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
