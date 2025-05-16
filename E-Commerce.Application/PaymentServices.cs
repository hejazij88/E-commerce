using E_Commerce.Application.Contact.Payment;
using E_commerce.Domain.PaymentAgg;

namespace E_Commerce.Application;

public class PaymentServices:IPaymentServices
{
    private readonly IPaymentRepository _paymentRepository;

    public PaymentServices(IPaymentRepository paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }

    public void Create(CreatePayment createPayment) =>
        _paymentRepository.Create(new Payment(createPayment.OrderId, createPayment.Amount,
            createPayment.PaymentMethod));
}