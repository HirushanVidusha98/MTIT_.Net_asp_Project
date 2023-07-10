using Sliit.MTIT_100.Customer.Data;
using Sliit.MTIT_100.Customer.Model;
using System.Reflection;

namespace Sliit.MTIT_100.Customer.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly DbContextClass _dbContext;

        public CustomerService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Model.Customer> GetCustomerList()
        {
            return _dbContext.Customer.ToList();
        }
        public Model.Customer GetCustomerById(int id)
        {
            return _dbContext.Customer.Where(x => x.Id == id).FirstOrDefault();
        }

        public Model.Customer AddCustomer(Model.Customer customer)
        {
            var result = _dbContext.Customer.Add(customer);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public Model.Customer UpdateCustomer(Model.Customer customer)
        {
            var result = _dbContext.Customer.Update(customer);
            _dbContext.SaveChanges();
            return result.Entity;
        }
        public bool DeleteCustomer(int Id)
        {
            var filteredData = _dbContext.Customer.Where(x => x.Id == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
           
            _dbContext.SaveChanges();
        
            return result != null ? true : false;
        }
    }
}
