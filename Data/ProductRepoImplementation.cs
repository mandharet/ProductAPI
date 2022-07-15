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
        public IEnumerable<ProductDetail> GetALLProducts()
        {
            return _db.productDetails;
        }

        public ProductDetail GetProductById(int id)
        {
            return _db.productDetails.FirstOrDefault(k => k.Id==id);
        }
    }
}
