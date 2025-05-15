using _0_Framework.Domain;

namespace E_commerce.Domain.OrderAgg;

public class Order:EntityBase
{
    public Guid UserId { get;private set; }
    public DateTime OrderDate { get; private set; }
    public string Status { get; private set; }
    public float Amount { get; private set; }

    public Order(Guid userId , string status, float amount)
    {
        UserId = userId;
        Status = status;
        Amount = amount;
        OrderDate = DateTime.Now;
    }

    public void Edit(Guid userId, string status, float amount)
    {
        UserId = userId;
        Status = status;
        Amount = amount;
    }

}