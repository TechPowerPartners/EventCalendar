using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Template.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        return services;
    }
}