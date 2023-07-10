using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT_100.Customer.Model;
using Sliit.MTIT_100.Customer.Services;
using System.Reflection;

namespace Sliit.MTIT_100.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService _customerService)
        {
            customerService = _customerService;
        }

        [HttpGet]
        public IEnumerable<Model.Customer> CustomerList()
        {
            var customerList = customerService.GetCustomerList();
            return customerList;

        }

        [HttpGet("{id}")]
        public Model.Customer GetCustomerById(int id)
        {
            return customerService.GetCustomerById(id);
        }

        [HttpPost]
        public Model.Customer AddCustomer(Model.Customer customer)
        {
            return customerService.AddCustomer(customer);
        }

        [HttpPut]
        public Model.Customer UpdateCustomer(Model.Customer customer)
        {
            return customerService.UpdateCustomer(customer);
        }

        [HttpDelete("{id}")]
        public bool DeleteCustomer(int id)
        {
            return customerService.DeleteCustomer(id);
        }
    }
}
