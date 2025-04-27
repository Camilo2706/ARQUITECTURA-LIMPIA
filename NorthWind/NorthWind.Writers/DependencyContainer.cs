using Microsoft.Extensions.DependencyInjection;
using NorthWind.Writers;

namespace Microsoft.Extensions.DependecyInjection;
public static class DependecyContainer
{
    public static IServiceCollection AddConsoleWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, ConsoleWriter>();
        return services;
    }
    public static IServiceCollection AddDebugWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, DebugWriter>();
        return services;
    }
    public static IServiceCollection AddFileWriter(this IServiceCollection services)
    {
        services.AddSingleton<IUserActionWriter, FileWriter>();
        return services;
    }
}