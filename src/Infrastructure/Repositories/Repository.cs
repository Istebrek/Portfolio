using Application.IRepositories;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly IMongoCollection<T> Collection;
    public Repository(IMongoDatabase db, string collectionName)
    {
        Collection = db.GetCollection<T>(collectionName);
    }


    public void Add(T entity)
    {
        Collection.InsertOne(entity);
    }

    public async Task DeleteAsync(string id)
    {
        var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));

        await Collection.DeleteOneAsync(filter);
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await Collection.Find(_ => true).ToListAsync();
    }

    public async Task<T?> GetByIdAsync(string id)
    {
        var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));
        return await Collection.Find(filter).FirstOrDefaultAsync();
    }

    public async Task UpdateAsync(string id, T entity)
    {
        var filter = Builders<T>.Filter.Eq("_id", new ObjectId(id));

        await Collection.ReplaceOneAsync(filter, entity);
    }
}