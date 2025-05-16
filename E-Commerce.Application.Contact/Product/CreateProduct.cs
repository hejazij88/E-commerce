namespace E_Commerce.Application.Contact.Product;

public class CreateProduct
{
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }
    public Guid CategoryId { get; set; }
}