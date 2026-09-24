using Shared.Lists;
using Shared.Models;

namespace UI.Services;

public class ProjectService(HttpClient http) :  IProjectService
{
    const string route = "/api/project";
    public async Task<List<ProjectSummaryDto>> GetAllSummaries(Language language)
    {
        return await http.GetFromJsonAsync<List<ProjectSummaryDto>>($"{route}/summaries?language={language}")
            ?? [];
    }
}

public interface IProjectService
{
    Task<List<ProjectSummaryDto>> GetAllSummaries(Language language);
}