using Microsoft.AspNetCore.Components;
using Shared.Lists;
using Shared.Models;

namespace UI.Services;

public class ListHandler(
    IProjectService projectService
) : IListHandler
{
    public List<ProjectSummaryDto>? ProjectSummaries { get; set; }
    public List<ProjectDetailDto>? ProjectDetails { get; set; }
    public ProjectSummaryDto? ProjectSummary { get; set; }
    public ProjectDetailDto? ProjectDetail { get; set; }

    public Action? OnChange { get; set; }


    public async Task GetAllData(Language language)
    {
        await GetProjects(language, null);
        OnChange?.Invoke();
    }
    private async Task GetProjects(Language language, string? id)
    {
        ProjectSummaries = await projectService!.GetAllSummaries(language);
        ProjectDetails = await projectService!.GetAllDetails(language);

        if(id is not null)
        {
            ProjectSummary = await projectService!.GetSummaryById(id, language);
            ProjectDetail = await projectService!.GetDetailById(id, language);
        }

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
    List<ProjectDetailDto>? ProjectDetails { get; set; }
    ProjectSummaryDto? ProjectSummary { get; set; }
    ProjectDetailDto? ProjectDetail { get; set; }

    Action? OnChange { get; set; }

    Task GetAllData(Language language);
}