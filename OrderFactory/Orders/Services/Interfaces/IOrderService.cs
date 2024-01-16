using OrderFactory.Orders.Enums;

namespace OrderFactory.Orders.Services.Interfaces;

public interface IOrderService
{
    public Departments Department { get; }

    public string GenerateMessage(string message);
}
