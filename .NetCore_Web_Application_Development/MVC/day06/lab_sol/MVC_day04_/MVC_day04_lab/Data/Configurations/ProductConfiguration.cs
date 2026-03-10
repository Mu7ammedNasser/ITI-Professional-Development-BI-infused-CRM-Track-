using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_day04_lab.Models;

namespace MVC_day04_lab.Data.Configurations
{
    public class ProductConfiguration
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryId)
                   .IsRequired();
        }
    }
}
