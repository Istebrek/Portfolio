using Microsoft.AspNetCore.Components;
using Shared.Lists;
using Shared.Models;

namespace UI.Services;

public class ObjectStore(
    IProjectService projectService
) : IObjectStore
{
    public List<ProjectSummaryDto>? ProjectSummariesSwe { get; set; }
    public List<ProjectSummaryDto>? ProjectSummariesEng { get; set; }
    public List<ProjectSummaryDto>? CurrentProjectSummaries { get; set; }

    public ProjectDetailDto? ProjectDetailSwe { get; set; }
    public ProjectDetailDto? ProjectDetailEng { get; set; }
    public ProjectDetailDto? CurrentProjectDetail { get; set; }

    public Action? OnChange { get; set; }


    public async Task GetAllObjects(Language language)
    {
        await GetProjects(language);
        OnChange?.Invoke();
    }

    private async Task GetProjects(Language language)
    {
        switch (language)
        {
            case Language.Swedish:
                ProjectSummariesSwe ??= await GetProjectSummaries(language);
                CurrentProjectSummaries = ProjectSummariesSwe;
                break;

            case Language.English:
                ProjectSummariesEng ??= await GetProjectSummaries(language);
                CurrentProjectSummaries = ProjectSummariesEng;
                break;

            default:
                ProjectSummariesSwe = await GetProjectSummaries(Language.Swedish);
                CurrentProjectSummaries = ProjectSummariesSwe;
                break;
        }
        if (CurrentProjectDetail is not null)
        {
            await GetProjectDetails(language, CurrentProjectDetail.Id);
        }
        OnChange!.Invoke();
    }

    public async Task GetProjectDetails(Language language, string id)
    {
        CurrentProjectDetail = await projectService!.GetDetailById(id, language);
    }

    private async Task GetEducations()
    {
        
    }

    private async Task GetExperiences()
    {
        
    }

    private async Task<List<ProjectSummaryDto>> GetProjectSummaries(Language language)
    {
        return await projectService!.GetAllSummaries(language);
    }
}

public interface IObjectStore
{
    public List<ProjectSummaryDto>? ProjectSummariesSwe { get; set; }
    public List<ProjectSummaryDto>? ProjectSummariesEng { get; set; }
    public List<ProjectSummaryDto>? CurrentProjectSummaries{ get; set; }
    public ProjectDetailDto? CurrentProjectDetail { get; set; }

    Action? OnChange { get; set; }

    Task GetAllObjects(Language language);
    Task GetProjectDetails(Language language, string id);
}