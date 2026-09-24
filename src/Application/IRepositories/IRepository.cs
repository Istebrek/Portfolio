namespace Application.IRepositories;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(string id);
    void Add(T entity);
    Task UpdateAsync(string id, T entity);
    Task DeleteAsync(string id);
}
