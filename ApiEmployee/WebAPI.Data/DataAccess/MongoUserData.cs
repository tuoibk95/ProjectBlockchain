namespace WebAPI.Data.DataAccess;

public class MongoUserData
{
    private readonly IDBConnection _db;

    public MongoUserData(IDBConnection db)
    {
        _db = db;
    }
}
