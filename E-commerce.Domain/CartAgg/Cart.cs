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


    public Cart(Guid userId, DateTime creationDate)
    {
        UserId = userId;
        CreationDate = creationDate;
    }

    public void Edit(Guid userId, DateTime creationDate)
    {
        UserId = userId;
        CreationDate = creationDate;
    }

}