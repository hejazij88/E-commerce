using _0_Framework.Domain;

namespace E_commerce.Domain.PaymentAgg;

public class Payment:EntityBase
{
    public Guid OrderId { get;private set; }
    public DateTime PaymentDate { get; private set; }
    public float Amount { get; private set; }
    public string PaymentMethod { get; private set; }

    public Payment(Guid orderId, DateTime paymentDate, float amount, string paymentMethod)
    {
        OrderId = orderId;
        PaymentDate = paymentDate;
        Amount = amount;
        PaymentMethod = paymentMethod;
    }
}