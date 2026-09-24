using Application.IRepositories;
using Application.IServices;
using Application.Services;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Shared.Models;

namespace Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication (this IServiceCollection services)
    {
        services.AddScoped<IEntityService<Project>>(sp =>
            new ProjectService(sp.GetRequiredService<IRepository<Project>>()));
        services.AddScoped<ISummaryDtoService<ProjectSummaryDto>>(sp =>
            new ProjectService(sp.GetRequiredService<IRepository<Project>>()));
        services.AddScoped<IDetailsDtoService<ProjectDetailsDto>>(sp =>
            new ProjectService(sp.GetRequiredService<IRepository<Project>>()));

        return services;
    }
}