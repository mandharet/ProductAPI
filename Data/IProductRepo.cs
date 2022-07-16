using ProductAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Data
{
    public interface IProductRepo
    {
        Task<IEnumerable<ProductDetail>> GetALLProducts();

        Task<ProductDetail> GetProductById(int id);
        Task AddProduct(ProductDetail prod);
    }
}
