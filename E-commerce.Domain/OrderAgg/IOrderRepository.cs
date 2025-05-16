using _0_Framework.Domain;
using E_commerce.Domain.CartAgg;

namespace E_commerce.Domain.OrderAgg;

public interface IOrderRepository:IRepository<Guid,Order>
{
    void PlaceOrder(Order order);
    Order TrackOrder(Guid orderId);
    void CancelOrder(Guid orderId);
}