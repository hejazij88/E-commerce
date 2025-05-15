using _0_Framework.Domain;

namespace E_commerce.Domain.PaymentAgg;

public interface IPaymentRepository:IRepository<Guid,Payment>
{
    void Process(Payment payment);
    Payment RefundPayment(Guid paymentId);
}