using _0_Framework.Domain;
using E_commerce.Domain.ProductAgg;

namespace E_commerce.Domain.CartAgg;

public interface ICartRepository:IRepository<Guid,Cart>
{
    float GetPrice(Guid cartId);
}