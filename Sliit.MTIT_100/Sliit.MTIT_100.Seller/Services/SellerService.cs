using Sliit.MTIT_100.Seller.Data;
using Sliit.MTIT_100.Seller.Models;

namespace Sliit.MTIT_100.Seller.Services
{
    public class SellerService:ISellerService
    {
        private readonly DbContextClass _dbContext;

        public SellerService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Models.Seller> GetSellerList()
        {
            return _dbContext.Sellers.ToList();
        }
        public Models.Seller GetSellerById(int id)
        {
            return _dbContext.Sellers.Where(x => x.SellerId == id).FirstOrDefault();
        }

        public Models.Seller AddSeller(Models.Seller seller)
        {
            var result = _dbContext.Sellers.Add(seller);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public Models.Seller UpdateSeller(Models.Seller seller)
        {
            var result = _dbContext.Sellers.Update(seller);
            _dbContext.SaveChanges();
            return result.Entity;
        }
        public bool DeleteSeller(int Id)
        {
            var filteredData = _dbContext.Sellers.Where(x => x.SellerId == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }
    }
}
