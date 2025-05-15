using _0_Framework.Domain;
using E_commerce.Domain.CartAgg;

namespace E_commerce.Domain.OrderAgg;

public interface IOrderRepository:IRepository<Guid,Order>
{
    void PlaceOrder(Guid userId, Cart cart);
    Order TrackOrder(Guid orderId);
    void CancelOrder(Guid orderId);
}