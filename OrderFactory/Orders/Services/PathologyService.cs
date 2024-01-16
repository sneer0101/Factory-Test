using OrderFactory.Orders.Enums;
using OrderFactory.Orders.Services.Interfaces;

namespace OrderFactory.Orders.Services;

internal class PathologyService : IOrderService
{
    public Departments Department => Departments.Pathology;

    public string GenerateMessage(string message) => $"Pathology Service: {message}";
}
