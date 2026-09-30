using Application.IRepositories;
using Application.IServices;
using Shared.Models;
using Shared.Lists;
using Domain.Entities;
using MongoDB.Bson;

namespace Application.Services;

public class ProjectService(IRepository<Project> repo) : IEntityService<Project>, ISummaryDtoService<ProjectSummaryDto>, IDetailsDtoService<ProjectDetailDto>
{
    public void Add(Project project)
    {
        project.Id = ObjectId.GenerateNewId();
        repo.Add(project);
    }

    public async Task DeleteAsync(string id)
    {
        await repo.DeleteAsync(id);
    }

    public async Task UpdateAsync(string id, Project project)
    {
        await repo.UpdateAsync(id, project);
    }



    public async Task<List<ProjectSummaryDto>> GetAllSummariesAsync(Language language)
    {
        var projects = await repo.GetAllAsync();
        return projects.Select(project => MapToSummary(project, language)).ToList();
    }

    public async Task<ProjectSummaryDto?> GetSummaryByIdAsync(string id, Language language)
    {
        var project = await repo.GetByIdAsync(id);

        if (project is null)
        {
            return null;
        }

        return MapToSummary(project, language);
    }



    public async Task<ProjectDetailDto?> GetDetailsByIdAsync(string id, Language language)
    {
        var project = await repo.GetByIdAsync(id);

        if (project is null)
        {
            return null;
        }

        return MapToDetails(project, language);
    }

    public async Task<List<ProjectDetailDto>> GetAllDetailsAsync(Language language)
    {
        var projects = await repo.GetAllAsync();
        return projects.Select(project => MapToDetails(project, language)).ToList();
    }



    private ProjectDetailDto MapToDetails(Project project, Language language)
    {
        var translation = project.Translations.FirstOrDefault(x => x.Language == language)
            ?? project.Translations.First(x => x.Language == Language.English);

        return new ProjectDetailDto(
            project.Id.ToString(),
            translation.Title,
            translation.Description,
            translation.Instructions,
            project.GitHubUrl,
            project.DemoUrl,
            project.Collaborators,
            project.Skills,
            project?.ImagePaths
        );
    }

    private ProjectSummaryDto MapToSummary(Project project, Language language)
    {
        var translation = project.Translations.FirstOrDefault(x => x.Language == language)
            ?? project.Translations.First(x => x.Language == Language.English);

        return new ProjectSummaryDto(
            project.Id.ToString(),
            translation.Title,
            translation.Description,
            project.Skills,
            project?.ImagePaths?.FirstOrDefault()
        );
    }
}