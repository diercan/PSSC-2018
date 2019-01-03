using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Products
{
    interface IProductService
    {
        ProductDTO Get(Guid productId);
        List<ProductDTO> GetAll();
        ProductDTO Add(ProductDTO product);
    }
}
