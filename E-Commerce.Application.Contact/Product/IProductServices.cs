namespace E_Commerce.Application.Contact.Product;

public interface IProductServices
{
    void Create(CreateProduct createProduct);
    void EditProduct(EditProduct  editProduct);
    ShowProduct Get(Guid productId);
    List<ShowProduct> GetShowProducts();
}