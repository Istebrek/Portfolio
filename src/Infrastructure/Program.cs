using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Application.IRepositories;
using Domain.Entities;
using Infrastructure.Repositories;

namespace Infrastructure;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        var atlasConnectionString = config.GetConnectionString("Atlas");

        services.AddSingleton<IMongoClient>(_ => 
            new MongoClient(atlasConnectionString));

        services.AddSingleton<IMongoDatabase> (sp =>
            sp.GetRequiredService<IMongoClient>().GetDatabase("Portfolio"));

        services.AddScoped<IRepository<Project>>(sp =>
            new Repository<Project>(sp.GetRequiredService<IMongoDatabase>(), "Projects"));

        services.AddScoped<IRepository<Education>>(sp =>
            new Repository<Education>(sp.GetRequiredService<IMongoDatabase>(), "Educations"));

        services.AddScoped<IRepository<Experience>>(sp =>
            new Repository<Experience>(sp.GetRequiredService<IMongoDatabase>(), "Experiences"));

        return services;

    }
}