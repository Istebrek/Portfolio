using Microsoft.Extensions.Options;
using Microsoft.OpenApi;

namespace API.Helpers;

public static class SwaggerSetup
{
    public static IServiceCollection AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Istebrek's Portfolio API",
                Version = "v1"
            });
        });


        return services;
    }
}