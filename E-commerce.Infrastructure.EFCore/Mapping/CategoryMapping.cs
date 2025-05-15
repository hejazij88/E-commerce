using E_commerce.Domain.CategoryAgg;
using E_commerce.Domain.ProductAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_commerce.Infrastructure.EFCore.Mapping;

public class CategoryMapping:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name).IsRequired().HasMaxLength(255);
        builder.Property(c => c.Description).IsRequired();
        builder.HasMany<Product>(c => c.ProductList).WithOne(p=>p.Category).HasForeignKey(c=>c.CategoryId);
    }
}