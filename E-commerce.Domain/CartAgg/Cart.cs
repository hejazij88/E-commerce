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


    public Cart(Guid userId,Product product)
    {
        UserId = userId;
        CreationDate = DateTime.Now;
        Products.Add(product);
    }
    
    public void Edit(Guid userId, DateTime creationDate,List<Product> products)
    {
        UserId = userId;
        CreationDate = creationDate;
        Products= products;
    }

}