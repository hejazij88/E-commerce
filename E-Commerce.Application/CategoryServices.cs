using E_Commerce.Application.Contact.Category;
using E_commerce.Domain.CategoryAgg;

namespace E_Commerce.Application;

public class CategoryServices:ICategoryServices
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryServices(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void Create(CreateCategory category)
    {
        _categoryRepository.Create(new Category(category.Name,category.Description));
        _categoryRepository.SaveChanges();
    }

    public void EditCategory(EditCategory category)
    {
        var responseData = _categoryRepository.Get(category.Id);
        responseData.EditCategory(category.Name,category.Description);
        _categoryRepository.SaveChanges();
    }

    public EditCategory Get(Guid id)
    {
        var category = _categoryRepository.Get(id);
        return new EditCategory
        {
            Name = category.Name,
            Description = category.Description,
            Id = category.Id
        };
    }

    public List<EditCategory> GetCategories()
    {
        var list = _categoryRepository.Get();
        List<EditCategory> categories = new List<EditCategory>();
        foreach (var category in list)
        {
            categories.Add(new EditCategory{Description = category.Description,Name = category.Name,Id = category.Id});
        }
        return categories;
    }
}