using OrderFactory.Orders.Enums;
using OrderFactory.Orders.Services.Interfaces;

namespace OrderFactory.Orders.Services;

internal class HistopathologyService : IOrderService
{
    public Departments Department => Departments.Histopathology;

    public string GenerateMessage(string message) => $"Histopathology Service: {message}";
}
