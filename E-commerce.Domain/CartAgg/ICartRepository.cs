using _0_Framework.Domain;
using E_commerce.Domain.ProductAgg;

namespace E_commerce.Domain.CartAgg;

public interface ICartRepository:IRepository<Guid,Cart>
{
    void AddItem(Guid userId, Product item);
    void RemoveItem(Guid cartId, Guid itemId);
    float GetPrice(Guid cartId);
}