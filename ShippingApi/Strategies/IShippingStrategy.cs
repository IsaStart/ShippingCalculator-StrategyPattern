using ShippingApi.Models;

namespace ShippingApi.Strategies
{
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }
}
