using ShippingApi.Models;

namespace ShippingApi.Strategies
{
    public class UPSShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order) => order.TotalWeight * 0.5;
    }
}
