using _0_Framework.Domain;
using E_commerce.Domain.OrderAgg;
using E_commerce.Domain.ProductAgg;

namespace E_commerce.Domain.CartAgg;

public class Cart:EntityBase
{
    public Guid UserId { get;private set; }
    public DateTime CreationDate { get; private set; }

    public List<Product> Products { get; private set; }
    public Order Order { get; private set; }


    public Cart(Guid userId,List<Product> product)
    {
        UserId = userId;
        CreationDate = DateTime.Now;
        Products=product;
    }
    
    public void Edit(Guid userId,List<Product> products)
    {
        UserId = userId;
        Products= products;
    }

}