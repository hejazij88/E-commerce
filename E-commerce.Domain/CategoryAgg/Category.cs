using _0_Framework.Domain;
using E_commerce.Domain.ProductAgg;

namespace E_commerce.Domain.CategoryAgg;

public class Category:EntityBase
{
    public string Name { get;private set; }
    public string Description { get; private set; }

    public List<Product> ProductList { get;private set; }

    public Category(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void EditCategory(string name, string description)
    {
        Name = name;
        Description = description;
    }

}