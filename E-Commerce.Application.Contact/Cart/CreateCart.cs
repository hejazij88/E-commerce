using E_Commerce.Application.Contact.Product;

namespace E_Commerce.Application.Contact.Cart;

public class CreateCart
{
    public Guid UserId { get; set; }
    public List<EditProduct> Products { get; set; }
}