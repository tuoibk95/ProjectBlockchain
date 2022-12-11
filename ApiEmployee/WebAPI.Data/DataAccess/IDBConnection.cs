using WebAPI.Data.Models;

namespace WebAPI.Data.DataAccess;

public interface IDBConnection
{
    string CategoryCollectionName { get; }
    IMongoCollection<CategoryModel> CategoryCollectoion { get; }
    MongoClient Client { get; }
    string DbName { get; }
    IMongoCollection<StatusModel> StatusCollection { get; }
    string StatusCollectionName { get; }
    IMongoCollection<SuggestionModel> SuggestionCollection { get; }
    string SuggestionCollectionName { get; }
}