using Microsoft.EntityFrameworkCore;

namespace E_commerce.Infrastructure.EFCore;

public class ECommerceContext:DbContext
{
    public ECommerceContext(DbContextOptions<ECommerceContext> options):base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {


        base.OnConfiguring(optionsBuilder);
    }
}