using _0_Framework.Domain;

namespace E_commerce.Domain.CartAgg;

public class Cart:EntityBase
{
    public Guid UserId { get;private set; }
    public DateTime CreationDate { get; private set; }

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