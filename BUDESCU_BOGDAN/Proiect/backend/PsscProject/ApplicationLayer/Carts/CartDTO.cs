using PsscProject.ApplicationLayer.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Carts
{
    [Table("cart")]
    public class CartDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public List<CartProductDTO> Products { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
