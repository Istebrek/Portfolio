using Shared.Lists;

namespace Application.IServices;

public interface IDetailsDtoService<T> where T : class
{
    Task<T?> GetDetailsByIdAsync(string id, Language language);
    Task<List<T>> GetAllDetailsAsync(Language language);
}