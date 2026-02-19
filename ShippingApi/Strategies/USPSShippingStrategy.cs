using ShippingApi.Models;

namespace ShippingApi.Strategies
{
    public class USPSShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order) => order.TotalWeight * 0.4;
    }
}
