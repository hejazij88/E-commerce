using E_Commerce.Application.Contact.Order;
using E_commerce.Domain.OrderAgg;

namespace E_Commerce.Application;

public class OrderServices:IOrderServices
{
    private readonly IOrderRepository _orderRepository;

    public OrderServices(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public void Create(CreateOrder createOrder) =>
        _orderRepository.PlaceOrder(new Order(createOrder.UserId, createOrder.Status, createOrder.Cart));

    public ShowOrder GetOrder(Guid id)
    {
        var order = _orderRepository.Get(id);
        return new ShowOrder { Date = order.OrderDate,Id = order.Id,Status = order.Status};
    }

    public List<ShowOrder> GetOrders()
    {
        var list = _orderRepository.Get();
        var orders = new List<ShowOrder>();
        foreach (var order in list)
        {
            orders.Add(new ShowOrder { Id = order.Id,Date = order.OrderDate,Status = order.Status});
        }
        return orders;
    }
}