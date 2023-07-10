using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT_100.Order.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT_100.Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService ;
        }

        
        /// <summary>
        /// Get all orders
        /// </summary>
        /// <returns>return the list of orders</returns>
        [HttpGet]
        public IEnumerable<Models.Order> OrderList()
        {
            var orderList = orderService.GetOrderList();
            return orderList;

        }

        /// <summary>
        /// Get order by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the order with the passed ID</returns>
        [HttpGet("{id}")]
        public Models.Order GetOrderById(int id)
        {
            return orderService.GetOrderById(id);
        }

        /// <summary>
        /// Add Orders
        /// </summary>
        /// <param name="order"></param>
        /// <returns>Return the added order</returns>
        [HttpPost]
        public Models.Order AddOrder(Models.Order order)
        {
            return orderService.AddOrder(order);
        }

        /// <summary>
        /// Update the order
        /// </summary>
        /// <param name="order"></param>
        /// <returns>Return the updated order</returns>
        [HttpPut]
        public Models.Order UpdateOrder(Models.Order order)
        {
            return orderService.UpdateOrder(order);
        }


        /// <summary>
        /// Delete the order with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public bool DeleteOrder(int id)
        {
            return orderService.DeleteOrder(id);
        }
    }
}
