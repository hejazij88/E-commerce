using _0_Framework.Domain;
using E_commerce.Domain.CartAgg;
using E_commerce.Domain.PaymentAgg;

namespace E_commerce.Domain.OrderAgg;

public class Order:EntityBase
{
    public Guid UserId { get;private set; }
    public DateTime OrderDate { get; private set; }
    public string Status { get; set; }
    public float Amount { get; private set; }
    public Guid CartId { get; private set; }
    public Cart Cart { get; private set; }
    public Payment Payment { get; private set; }




    public Order(Guid userId , string status, Cart cart)
    {
        UserId = userId;
        Status = status;
        Amount = CalculateAmount(cart);
        OrderDate = DateTime.Now;
    }

    private float CalculateAmount(Cart cart)
    {
        return cart.Products.Sum(p => p.Price);
    }

    public void Edit(Guid userId, string status, float amount)
    {
        UserId = userId;
        Status = status;
        Amount = amount;
    }

}