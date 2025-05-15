using E_commerce.Domain.CartAgg;
using E_commerce.Domain.CategoryAgg;
using E_commerce.Domain.ProductAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_commerce.Infrastructure.EFCore.Mapping;

public class ProductMapping : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(c => c.Id);

        builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
        builder.Property(p => p.Description).IsRequired();
        builder.Property(p => p.Price).IsRequired();
        builder.Property(p => p.Stock).IsRequired();

        builder.HasOne<Category>(p => p.Category).WithMany(c => c.ProductList).HasForeignKey(p => p.CategoryId);
        builder.HasMany<Cart>(p => p.Carts).WithMany(c => c.Products);
    }
}