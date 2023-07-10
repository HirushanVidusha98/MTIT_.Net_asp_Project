namespace Sliit.MTIT_100.Order.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public string? BillingAddress { get; set; }
        public double? OrderTotal { get; set; }
        public string? PaymentMethod { get; set; }
        
    }
}
