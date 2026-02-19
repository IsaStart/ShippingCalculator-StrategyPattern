namespace ShippingApi.Models
{
    public class Order
    {
        public double TotalWeight { get; set; }
        public string ShippingMethod { get; set; } // e.g., "UPS", "FedEx"
    }
}
