using ShippingApi.Models;
using ShippingApi.Strategies;

namespace ShippingApi.Services
{
    public class ShippingCalculatorService
    {
        private readonly Dictionary<string, IShippingStrategy> _strategies;
        public ShippingCalculatorService() 
        { 
            _strategies = new Dictionary<string, IShippingStrategy> 
            { 
                { "UPS", new UPSShippingStrategy() }, 
                { "FedEx", new FedExShippingStrategy() }, 
                { "USPS", new USPSShippingStrategy() } 
            }; 
        }

        public double CalculateShippingCost(Order order) 
        { 
            if (_strategies.ContainsKey(order.ShippingMethod)) 
            { 
                return _strategies[order.ShippingMethod].Calculate(order); 
            } 
            throw new ArgumentException("Invalid shipping method"); 
        }
    }
}
