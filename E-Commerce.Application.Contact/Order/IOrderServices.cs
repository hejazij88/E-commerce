namespace E_Commerce.Application.Contact.Order;

public interface IOrderServices
{
    void Create(CreateOrder createOrder);
    ShowOrder GetOrder(Guid id);
    List<ShowOrder> GetOrders();
}