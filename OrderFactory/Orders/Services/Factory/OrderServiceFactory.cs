using OrderFactory.Orders.Constants;
using OrderFactory.Orders.Enums;
using OrderFactory.Orders.Services.Interfaces;

namespace OrderFactory.Orders.Services.Factory;

public sealed class OrderServiceFactory(IEnumerable<IOrderService> orderServices) : IOrderServiceFactory
{
    private IEnumerable<IOrderService> OrderServices { get; } = orderServices;

    public IOrderService Resolve(string department)
    {
        return this.OrderServices
            .FirstOrDefault(o => o.Department == DepartmentDictionary()[department]) ?? throw new NotSupportedException();
    }

    private static Dictionary<string, Departments> DepartmentDictionary() => new()
        {
            { DepartmentConstants.Histopathology, Departments.Histopathology },
            { DepartmentConstants.Pathology, Departments.Pathology }
        };
}
