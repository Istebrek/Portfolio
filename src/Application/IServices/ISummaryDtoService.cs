using Shared.Lists;

namespace Application.IServices;

public interface ISummaryDtoService<T> where T : class
{
    Task<T?> GetSummaryByIdAsync(string id, Language language);
    Task<List<T>> GetAllSummariesAsync(Language language);
}