using Microsoft.EntityFrameworkCore;
using ProductAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Data
{
    public class ProductRepoImplementation : IProductRepo
    {
        private readonly ApplicationDbContext _db;

        public ProductRepoImplementation(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task AddProduct(ProductDetail prod)
        {
            if (prod != null)
                _db.productDetails.Add(prod);
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductDetail>> GetALLProducts()
        {
            var obj = await _db.productDetails.ToListAsync();
            return obj;
        }

        public async Task<ProductDetail> GetProductById(int id)
        {
            var obj= await _db.productDetails.FirstOrDefaultAsync(k => k.Id==id);
            return obj;
        }
    }
}
