using E_commerce.Domain.OrderAgg;
using E_commerce.Domain.PaymentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_commerce.Infrastructure.EFCore.Mapping;

public class PaymentMapping : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payments");
        builder.HasKey(c => c.Id);
        builder.Property(p => p.PaymentMethod).IsRequired().HasMaxLength(255);
        builder.Property(p => p.Amount).IsRequired();

        builder.HasOne<Order>(p => p.Order).WithOne(o => o.Payment).HasForeignKey<Payment>(o => o.OrderId);


    }
}