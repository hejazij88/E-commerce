using E_Commerce.Application.Contact.Product;
using E_commerce.Domain.ProductAgg;
using E_Commerce.Application.Contact.Category;
using E_commerce.Domain.CategoryAgg;

namespace E_Commerce.Application;

public class ProductServices:IProductServices
{
    private readonly IProductRepository _repository;

    public ProductServices(IProductRepository repository)
    {
        _repository = repository;
    }

    public void Create(CreateProduct createProduct) => _repository.Create(new Product(createProduct.Name,
        createProduct.Description, createProduct.Price, createProduct.Stock));

    public void EditProduct(EditProduct editProduct)
    {
        var product = _repository.Get(editProduct.Id);
        product.Edit(editProduct.Name,editProduct.Description,editProduct.Price,editProduct.Stock);
        _repository.SaveChanges();
    }

    public ShowProduct Get(Guid productId)
    {
        var product= _repository.Get(productId);
        return new ShowProduct {Id = product.Id,Name = product.Name,Price = product.Price};
    }

    public List<ShowProduct> GetShowProducts()
    {
        var list = _repository.Get();
        List<ShowProduct> products = new List<ShowProduct>();
        foreach (var product in list)
        {
            products.Add(new ShowProduct() { Id = product.Id, Name = product.Name, Price = product.Price });
        }
        return products;
    }
}