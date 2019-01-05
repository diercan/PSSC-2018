using PsscProject.ApplicationLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Carts
{
    public class CartDTO
    {
        public Guid CustomerId { get; set; }
        public List<ProductDTO> Products { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
