using E_commerce.Domain.CartAgg;
using E_commerce.Domain.OrderAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_commerce.Infrastructure.EFCore.Mapping;

public class OrderMapping : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");
        builder.HasKey(c => c.Id);
        builder.Property(o => o.Status).IsRequired().HasMaxLength(255);
        builder.HasOne<Cart>(c => c.Cart).WithOne(o => o.Order).HasForeignKey<Order>(o => o.CartId);


    }
}