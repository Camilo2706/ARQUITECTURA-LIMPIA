using Microsoft.Extensions.DependencyInjection;
using NorthWind.Writers;

namespace Microsoft.Extensions.DependecyInjection;
public static class DependecyContainer
{
    public static IServiceCollection AddNorthWindServices(
        this IServiceCollection services)
    {
        services.AddDebugWriter();
        services.AddServices();
        return services;
    }
}