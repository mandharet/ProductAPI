using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data;
using ProductAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {

        IProductRepo _repo;
        public ProductDetailController(IProductRepo repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public IEnumerable<ProductDetail> GetAllProducts()
        {
            return _repo.GetALLProducts();
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDetail> GetProductById(int id)
        {
            var result = _repo.GetProductById(id);
            if (result != null) return result;
            return NotFound();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        //incomplete
        public ActionResult AddProduct([FromBody] ProductDetail prod)
        {
            _repo.AddProduct(prod);
            return NotFound();
        }
    }
}
