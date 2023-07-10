using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT_100.Seller.Models;
using Sliit.MTIT_100.Seller.Services;

namespace Sliit.MTIT_100.Seller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService sellerService;
        public SellerController(ISellerService _sellerService)
        {
            sellerService = _sellerService;
        }

        [HttpGet]
        public IEnumerable<Models.Seller> SellerList()
        {
            var sellerList = sellerService.GetSellerList();
            return sellerList;

        }

        [HttpGet("{id}")]
        public Models.Seller GetSellerById(int id)
        {
            return sellerService.GetSellerById(id);
        }

        [HttpPost]
        public Models.Seller AddSeller(Models.Seller seller)
        {
            return sellerService.AddSeller(seller);
        }

        [HttpPut]
        public Models.Seller UpdateSeller(Models.Seller seller)
        {
            return sellerService.UpdateSeller(seller);
        }

        [HttpDelete("{id}")]
        public bool DeleteSeller(int id)
        {
            return sellerService.DeleteSeller(id);
        }
    }
}
