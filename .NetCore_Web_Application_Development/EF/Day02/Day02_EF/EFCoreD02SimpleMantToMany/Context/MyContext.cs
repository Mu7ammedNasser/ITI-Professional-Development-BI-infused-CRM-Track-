using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreD02SimpleMantToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreD02SimpleMantToMany.Context
{
    internal class MyContext : DbContext
    {

        public MyContext() :base() { }

        public MyContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-DH7T4Q7;DataBase=EF_Day02_MtMSimple;Trusted_Connection=true;TrustServerCertificate=true";
                optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // do one of the following configuration to create many to many relationship
            //modelBuilder.Entity<Department>()
            //            .HasMany(d => d.Instructors)
            //            .WithMany(i => i.Departments);

            //modelBuilder.Entity<Instructor>()
            //            .HasMany(i => i.Departments)
            //            .WithMany(d => d.Instructors);


            base.OnModelCreating(modelBuilder); // important when use identity



        }
 
        public virtual DbSet<Instructor> employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
