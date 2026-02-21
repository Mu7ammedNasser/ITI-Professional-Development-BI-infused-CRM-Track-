using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_1_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace lab_1_EF
{
    internal class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //string connectionString = "Server=DESKTOP-DH7T4Q7;DataBase=EF_Day01_Demo;Trusted_Connection=true;TrustServerCertificate=true";
           // optionsBuilder.UseLazyLoadingProxies().
           //     UseSqlServer(connectionString);

           string connectionString = "Server=DESKTOP-DH7T4Q7;DataBase=EF_Day01_Lab_01;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }


    }
}
