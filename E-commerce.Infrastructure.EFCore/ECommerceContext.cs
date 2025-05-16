using E_commerce.Domain.CartAgg;
using E_commerce.Domain.CategoryAgg;
using E_commerce.Domain.OrderAgg;
using E_commerce.Domain.PaymentAgg;
using E_commerce.Domain.ProductAgg;
using E_commerce.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Infrastructure.EFCore;

public class ECommerceContext:DbContext
{
    public ECommerceContext(DbContextOptions<ECommerceContext> options):base(options)
    {
        
    }

    public DbSet<Cart> Carts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(CartMapping).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        base.OnModelCreating(modelBuilder);
    }
}