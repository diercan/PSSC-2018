using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Products
{
    public interface IProductService
    {
        ProductDTO Get(Guid productId);
        IEnumerable<ProductDTO> GetAll();
        ProductDTO Add(ProductDTO product);
        void Update(ProductDTO productDto);
        void Remove(Guid id);
    }
}
