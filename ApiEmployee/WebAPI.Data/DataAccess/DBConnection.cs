
using WebAPI.Data.Models;

namespace WebAPI.Data.DataAccess;

public class DBConnection : IDBConnection
{
    private readonly IConfiguration _config;
    private readonly IMongoDatabase _db;
    private string _connectionId = "MongoDB";
    public string DbName { get; private set; }
    public string CategoryCollectionName { get; private set; } = "categories";
    public string StatusCollectionName { get; private set; } = "statuses";
    //    public string UserCollectionName { get; private set; } = "users";
    public string SuggestionCollectionName { get; private set; } = "suggestions";

    public MongoClient Client { get; private set; }
    public IMongoCollection<CategoryModel> CategoryCollectoion { get; private set; }
    public IMongoCollection<StatusModel> StatusCollection { get; private set; }
    public IMongoCollection<SuggestionModel> SuggestionCollection { get; private set; }

    public DBConnection(IConfiguration config)
    {
        _config = config;
        Client = new MongoClient(_config.GetConnectionString(_connectionId));
        DbName = _config["DatabaseName"];
        _db = Client.GetDatabase(DbName);

        CategoryCollectoion = _db.GetCollection<CategoryModel>(CategoryCollectionName);
        StatusCollection = _db.GetCollection<StatusModel>(StatusCollectionName);
        SuggestionCollection = _db.GetCollection<SuggestionModel>(SuggestionCollectionName);
    }
}
