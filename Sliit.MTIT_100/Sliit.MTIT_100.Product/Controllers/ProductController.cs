using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT_100.Product.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT_100.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public IEnumerable<Models.Product> ProductList()
        {
            var productList = productService.GetProductList();
            return productList;

        }

        [HttpGet("{id}")]
        public Models.Product GetProductById(int id)
        {
            return productService.GetProductById(id);
        }

        [HttpPost]
        public Models.Product AddProduct(Models.Product product)
        {
            return productService.AddProduct(product);
        }

        [HttpPut]
        public Models.Product UpdateProduct(Models.Product product)
        {
            return productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public bool DeleteProduct(int id)
        {
            return productService.DeleteProduct(id);
        }
    }
}

