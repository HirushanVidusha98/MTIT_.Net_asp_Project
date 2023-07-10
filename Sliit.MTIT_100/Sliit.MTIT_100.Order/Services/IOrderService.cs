namespace Sliit.MTIT_100.Order.Services
{
    public interface IOrderService
    {
        public IEnumerable<Models.Order> GetOrderList();
        public Models.Order GetOrderById(int id);
        public Models.Order AddOrder(Models.Order order);
        public Models.Order UpdateOrder(Models.Order order);
        public bool DeleteOrder(int id);
       
    }
}
