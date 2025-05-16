using _0_Framework.Domain;
using E_commerce.Domain.OrderAgg;

namespace E_commerce.Domain.PaymentAgg;

public class Payment:EntityBase
{
    public Guid OrderId { get;private set; }
    public DateTime PaymentDate { get; private set; }
    public float Amount { get; private set; }
    public string PaymentMethod { get; private set; }

    public Order Order { get; private set; }

    public Payment(Guid orderId, float amount, string paymentMethod)
    {
        OrderId = orderId;
        PaymentDate = DateTime.Now;
        Amount = amount;
        PaymentMethod = paymentMethod;
    }
}