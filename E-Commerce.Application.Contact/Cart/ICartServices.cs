using System.Dynamic;

namespace E_Commerce.Application.Contact.Cart;

public interface ICartServices
{
    void Create(CreateCart createCart);
    void Edit(CreateCart createCart);
    EditCart GetCart(Guid CartId);
    List<EditCart> GetCarts();
    void AddItem(Guid productId);
    void RemoveItem(Guid productId);

}