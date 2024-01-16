using OrderFactory.Orders.Services.Interfaces;

namespace OrderFactory.Orders.Services.Factory;

internal interface IOrderServiceFactory
{
    IOrderService Resolve(string department);
}
