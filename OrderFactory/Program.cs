using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderFactory.Orders.Constants;
using OrderFactory.Orders.Services;
using OrderFactory.Orders.Services.Factory;
using OrderFactory.Orders.Services.Interfaces;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IOrderService, HistopathologyService>();
builder.Services.AddTransient<IOrderService, PathologyService>();
builder.Services.AddTransient<IOrderServiceFactory, OrderServiceFactory>();

using IHost host = builder.Build();

using IServiceScope serviceScope = host.Services.CreateScope();
IServiceProvider provider = serviceScope.ServiceProvider;

var factory = provider.GetService<IOrderServiceFactory>()!;

var histopathologyService = factory.Resolve(DepartmentConstants.Histopathology);
var pathologyService = factory.Resolve(DepartmentConstants.Pathology);

var histoMessage = histopathologyService.GenerateMessage("Histoservice hit");
var pathologyMessage = pathologyService.GenerateMessage("Pathoservice hit");

Console.WriteLine(histoMessage);
Console.WriteLine(pathologyMessage);
Console.ReadLine();

host.Run();

