using WebAPI.Data.Models;

namespace WebAPI.Data.DataAccess;

public class MongoCategoryData : ICategoryData
{
    private readonly IMongoCollection<CategoryModel> _categories;
    private readonly IMemoryCache _cache;
    private const string cacheName = "CategoryData";

    public MongoCategoryData(IDBConnection db, IMemoryCache cache)
    {
        _categories = db.CategoryCollectoion;
        _cache = cache;
    }

    public async Task<List<CategoryModel>> GetCategoryAsync()
    {
        var result = await _categories.FindAsync(_ => true);
        return result.ToList();
    }

    public async Task<List<CategoryModel>> GetCategories()
    {
        var output = _cache.Get<List<CategoryModel>>(cacheName);
        if (output is null)
        {
            var results = await _categories.FindAsync(_ => true);
            output = results.ToList();
            _cache.Set(cacheName, output, TimeSpan.FromDays(1));
        }
        return output;
    }

    public async Task<CategoryModel> GetCategory(string id)
    {
        var result = await _categories.FindAsync(c => c.Id == id);
        return result.FirstOrDefault();
    }

    //public async Task<CategoryModel> GetCategoryFromAuthentication(string objectId)
    //{
    //    var result = await _category.FindAsync(c => c.ObjectIdentifier == objectId);
    //    return result.FirstOrDefault();
    //}

    public Task CreateCategory(CategoryModel category)
    {
        return _categories.InsertOneAsync(category);
    }

    public Task UpdateCategory(CategoryModel category)
    {
        var filter = Builders<CategoryModel>.Filter.Eq("Id", category.Id);
        return _categories.ReplaceOneAsync(filter, category, new ReplaceOptions { IsUpsert = true });
    }
}
