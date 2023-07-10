using Sliit.MTIT_100.Order.Data;

namespace Sliit.MTIT_100.Order.Services
{
    public class OrderService : IOrderService
    {
        private readonly DbContextClass _dbContext;

        public OrderService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public Models.Order AddOrder(Models.Order order)
        {
            var result = _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteOrder(int id)
        {
            var filteredData = _dbContext.Orders.Where(x => x.OrderId == id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }

        public Models.Order GetOrderById(int id)
        {
            return _dbContext.Orders.Where(x => x.OrderId == id).FirstOrDefault();
        }

        public IEnumerable<Models.Order> GetOrderList()
        {
            return _dbContext.Orders.ToList();
        }
        public Models.Order UpdateOrder(Models.Order order)
        {
            var result = _dbContext.Orders.Update(order);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        
    }
}
