using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_3_EF_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Day_3_EF_Demo.Context
{
    internal class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionString = "Server=DESKTOP-DH7T4Q7;DataBase=EF_Day03_Demo;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seading 
            var departments = new List<Department>()
            {
                new Department(){DeptId=1, DeptName="IT"},
                new Department(){DeptId=2, DeptName="HR"},
                new Department(){DeptId=3, DeptName="Finance"},
            };
            var employees = new List<Emplyee>()
            {   
                new Emplyee() { Id = 1, Name = "Alice", Salary = 3000, Age = 22, DepartmentId = 2, Email = "Alice@example.com" },
                new Emplyee() { Id = 2, Name = "Bob", Salary = 4500, Age = 28, DepartmentId = 1, Email = "Bob@example.com" },
                new Emplyee() { Id = 3, Name = "Charlie", Salary = 3500, Age = 25, DepartmentId = 3, Email = "Charlie@example.com" },
                new Emplyee() { Id = 4, Name = "Diana", Salary = 5000, Age = 30, DepartmentId = 1, Email = "Diana@example.com" },
                new Emplyee() { Id = 5, Name = "Eve", Salary = 3200, Age = 24, DepartmentId = 2, Email = "Eve@example.com" },
                new Emplyee() { Id = 6, Name = "Frank", Salary = 4000, Age = 27, DepartmentId = 3, Email = "Frank@example.com" },
                new Emplyee() { Id = 7, Name = "Grace", Salary = 4800, Age = 29, DepartmentId = 1, Email = "Grace@example.com" },
                new Emplyee() { Id = 8, Name = "Henry", Salary = 3300, Age = 23, DepartmentId = 2, Email = "Henry@example.com" },
                new Emplyee() { Id = 9, Name = "Iris", Salary = 3800, Age = 26, DepartmentId = 3, Email = "Iris@example.com" },
                new Emplyee() { Id = 10, Name = "Jack", Salary = 5200, Age = 31, DepartmentId = 1, Email = "Jack@example.com" }

            };

            modelBuilder.Entity<Department>().HasData(departments);
            modelBuilder.Entity<Emplyee>().HasData(employees);
        }

        public virtual DbSet<Emplyee> emplyees { get; set; }
        public virtual DbSet<Department> departments { get; set; }

    }
}
