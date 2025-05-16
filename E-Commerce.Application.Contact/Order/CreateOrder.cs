namespace E_Commerce.Application.Contact.Order;

public class CreateOrder
{
    public Guid UserId { get; set; }
    public E_commerce.Domain.CartAgg.Cart Cart { get; set; }
    public string Status { get; set; }
    public float Amount { get; set; }
}