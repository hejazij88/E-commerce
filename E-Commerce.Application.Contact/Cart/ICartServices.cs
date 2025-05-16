using System.Dynamic;

namespace E_Commerce.Application.Contact.Cart;

public interface ICartServices
{
    void Create(CreateCart createCart);
    void Edit(EditCart editCart);
    EditCart GetCart(Guid CartId);
    List<EditCart> GetCarts();

}