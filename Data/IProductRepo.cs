using ProductAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Data
{
    public interface IProductRepo
    {
        IEnumerable<ProductDetail> GetALLProducts();

        ProductDetail GetProductById(int id);
    }
}
