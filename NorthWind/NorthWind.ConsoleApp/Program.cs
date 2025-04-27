using Microsoft.Extensions.DependecyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Writers;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();

using IHost AppHost = Builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.add("Demo", "Azúcar refinada");

/*
 * AppLoger y los Writers: Responsabilidad única
 * AppLogger: Abierto pero cerrado
 * AppLogger: Inversión de dependencias. Los módulos
 * de alto nivel son independientes de los detalles de implementación.
 */