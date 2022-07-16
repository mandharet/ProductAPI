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
        public async Task<IEnumerable<ProductDetail>> GetAllProducts()
        {
            var obj= await _repo.GetALLProducts();
            return obj;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetail>> GetProductById(int id)
        {
            var result = await _repo.GetProductById(id);
            if (result != null) return result;
            return NotFound();
        }

        [HttpPost("addproduct")]
        //[AutoValidateAntiforgeryToken]

        public async Task<ActionResult> AddProduct([FromBody] ProductDetail prod)
        {
            await _repo.AddProduct(prod);
            return Ok();
        }
    }
}
