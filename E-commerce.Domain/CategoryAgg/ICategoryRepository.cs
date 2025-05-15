using _0_Framework.Domain;
using E_commerce.Domain.ProductAgg;

namespace E_commerce.Domain.CategoryAgg;

public interface ICategoryRepository:IRepository<Guid,Category>
{
    void AddProduct(Product  product);
    void RemoveProduct(Guid  productId);
    List<Product> GetAllProducts();
}