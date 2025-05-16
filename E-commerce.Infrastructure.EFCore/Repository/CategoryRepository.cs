using _0_Framework.Infrastructure;
using E_commerce.Domain.CategoryAgg;
using E_commerce.Domain.ProductAgg;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Infrastructure.EFCore.Repository;

public class CategoryRepository:RepositoryBase<Guid,Category>,ICategoryRepository
{
    private readonly ECommerceContext _context;
    public CategoryRepository(ECommerceContext context) : base(context)
    {
        _context = context;
    }

    public void AddProduct(Product product)=>_context.Products.Add(product);

    public void RemoveProduct(Guid productId)
    {
        var product = _context.Products.FirstOrDefault(p=>p.Id==productId);
        _context.Products.Remove(product);
    }

    public List<Product> GetAllProducts() => _context.Products.ToList();
}