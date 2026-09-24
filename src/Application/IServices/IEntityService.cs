using Shared.Lists;

namespace Application.IServices;

public interface IEntityService<T> where T : class
{
    Task UpdateAsync(string id, T entity);
    void Add(T entity);
    Task DeleteAsync(string id);
}