using _0_Framework.Infrastructure;
using E_commerce.Domain.CartAgg;
using E_commerce.Domain.OrderAgg;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.Infrastructure.EFCore.Repository;

public class OrderRepository:RepositoryBase<Guid,Order>,IOrderRepository
{
    private readonly ECommerceContext _context;
    public OrderRepository(ECommerceContext context) : base(context)
    {
        _context = context;
    }

    public void PlaceOrder(Order order) => _context.Orders.Add(new Order(order.UserId,order.Status,order.Cart));

    public Order TrackOrder(Guid orderId) => _context.Orders.FirstOrDefault(o => o.Id == orderId);

    public void CancelOrder(Guid orderId)
    {
        var order=_context.Orders.FirstOrDefault(o => o.Id == orderId);
        order.Status = "Cancele";
        order.Edit(order.UserId,order.Status,order.Amount);
    }
}