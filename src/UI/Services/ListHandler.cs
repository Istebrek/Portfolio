using Microsoft.AspNetCore.Components;
using Shared.Lists;
using Shared.Models;

namespace UI.Services;

public class ListHandler(
    IProjectService projectService
) : IListHandler
{
    public List<ProjectSummaryDto>? ProjectSummaries { get; set; }

    public Action? OnChange { get; set; }

    public async Task GetAllData(Language language)
    {
        await GetProjects(language);
        OnChange?.Invoke();
    }
    private async Task GetProjects(Language language)
    {
        ProjectSummaries = await projectService!.GetAllSummaries(language);
    }
    private async Task GetEducations()
    {
        
    }
    private async Task GetExperiences()
    {
        
    }
}

public interface IListHandler
{
    List<ProjectSummaryDto>? ProjectSummaries { get; set; }

    Action? OnChange { get; set; }

    Task GetAllData(Language language);
}