using ShippingApi.Models;

namespace ShippingApi.Strategies
{
    public class FedExShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order) => order.TotalWeight * 0.7;
    }
}
