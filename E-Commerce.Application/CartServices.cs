using E_Commerce.Application.Contact.Cart;
using E_commerce.Domain.CartAgg;
using E_commerce.Domain.ProductAgg;

namespace E_Commerce.Application;

public class CartServices:ICartServices
{
    private readonly ICartRepository _cartRepository;

    public CartServices(ICartRepository cartRepository)
    {
        _cartRepository = cartRepository;
    }

    public void Create(CreateCart createCart)
    {
        _cartRepository.Create(new Cart(createCart.UserId,createCart.Product));
    }

    public void Edit(EditCart editCart)
    {
        var cart = _cartRepository.Get(editCart.Id);
        cart.Edit(editCart.UserId,editCart.Product);
        _cartRepository.SaveChanges();
    }

    public EditCart GetCart(Guid CartId)
    {
        var cart = _cartRepository.Get(CartId);
        return new EditCart { Id = cart.Id, Product = cart.Products, UserId = cart.UserId };
    }

    public List<EditCart> GetCarts()
    {
        var list = _cartRepository.Get();
        List<EditCart> carts= new List<EditCart>();
        foreach (var cart in list)
        {
            carts.Add(new EditCart
            {
                Id = cart.Id,Product = cart.Products, UserId = cart.UserId
            });
        }
        return carts;
    }
}