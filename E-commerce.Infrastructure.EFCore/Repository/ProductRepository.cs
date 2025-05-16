using _0_Framework.Infrastructure;
using E_commerce.Domain.ProductAgg;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Infrastructure.EFCore.Repository;

public class ProductRepository:RepositoryBase<Guid,Product>,IProductRepository
{
    private readonly ECommerceContext _context;
    public ProductRepository(ECommerceContext context) : base(context)
    {
        _context = context;
    }
}