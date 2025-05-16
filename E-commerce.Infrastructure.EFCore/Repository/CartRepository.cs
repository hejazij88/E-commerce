using _0_Framework.Infrastructure;
using E_commerce.Domain.CartAgg;
using E_commerce.Domain.ProductAgg;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Infrastructure.EFCore.Repository;

public class CartRepository:RepositoryBase<Guid,Cart>,ICartRepository
{
    private readonly ECommerceContext _context; 
    public CartRepository(ECommerceContext context) : base(context)
    {
        _context = context;
    }
    public float GetPrice(Guid cartId) => _context.Carts.Include(cart => cart.Products).FirstOrDefault(c => c.Id == cartId)!.Products.Sum(p => p.Price);
}