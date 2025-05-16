namespace E_Commerce.Application.Contact.Payment;

public class CreatePayment
{
    public float Amount { get;  set; }
    public string PaymentMethod { get; set; }
    public Guid OrderId { get; set; }
}