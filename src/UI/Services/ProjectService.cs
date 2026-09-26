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
    public async Task<List<ProjectDetailDto>> GetAllDetails(Language language)
    {
        return await http.GetFromJsonAsync<List<ProjectDetailDto>>($"{route}/details?language={language}")
            ?? [];
    }

    public async Task<ProjectSummaryDto?> GetSummaryById(string id, Language language)
    {
        var result = await http.GetFromJsonAsync<ProjectSummaryDto>($"{route}/summary/{id}?language={language}");

        if (result is null)
        {
            return null;
        }
        return result;
    }

    public async Task<ProjectDetailDto?> GetDetailById(string id, Language language)
    {
        var result = await http.GetFromJsonAsync<ProjectDetailDto>($"{route}/detail/{id}?language={language}");

        if (result is null)
        {
            return null;
        }
        return result;
    }
}

public interface IProjectService
{
    Task<List<ProjectSummaryDto>> GetAllSummaries(Language language);
    Task<List<ProjectDetailDto>> GetAllDetails(Language language);
    Task<ProjectSummaryDto?> GetSummaryById(string id, Language language);
    Task<ProjectDetailDto?> GetDetailById(string id, Language language);
}