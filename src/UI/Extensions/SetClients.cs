using UI.Services;

namespace UI.Extensions;

public static class SetClients
{
    public static IServiceCollection AddClients(this IServiceCollection services, IConfiguration config)
    {
        services.AddHttpClient<IProjectService, ProjectService>(client =>
            client.BaseAddress = new Uri (config["ApiUrl"]!));

        return services;
    }
}