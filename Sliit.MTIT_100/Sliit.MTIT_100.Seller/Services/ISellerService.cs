using Sliit.MTIT_100.Seller.Models;

namespace Sliit.MTIT_100.Seller.Services
{
    public interface ISellerService
    {
        public IEnumerable<Models.Seller> GetSellerList();
        public Models.Seller GetSellerById(int id);
        public Models.Seller AddSeller(Models.Seller seller);
        public Models.Seller UpdateSeller(Models.Seller seller);
        public bool DeleteSeller(int Id);
    }
}
 