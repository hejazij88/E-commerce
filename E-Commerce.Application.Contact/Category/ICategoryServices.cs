namespace E_Commerce.Application.Contact.Category;

public interface ICategoryServices
{
    void Create(CreateCategory category);
    void EditCategory(EditCategory category);
    EditCategory Get(Guid id);
    List<EditCategory> GetCategories();
}