using Sliit.MTIT_100.Customer.Model;
using System.Reflection;

namespace Sliit.MTIT_100.Customer.Services
{
    public interface ICustomerService
    {
        public IEnumerable<Model.Customer> GetCustomerList();
        public Model.Customer GetCustomerById(int id);
        public Model.Customer AddCustomer(Model.Customer customer);
        public Model.Customer UpdateCustomer(Model.Customer customer);
        public bool DeleteCustomer(int Id);
    }
}
