using WebAPI.Data.Models;

namespace WebAPI.Data.DataAccess
{
    public interface ICategoryData
    {
        Task CreateCategory(CategoryModel category);
        Task<CategoryModel> GetCategory(string id);
        Task<List<CategoryModel>> GetCategoryAsync();
        Task UpdateCategory(CategoryModel category);
    }
}