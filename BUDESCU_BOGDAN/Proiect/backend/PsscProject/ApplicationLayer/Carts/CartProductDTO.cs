using PsscProject.ApplicationLayer.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Carts
{
    [Table("cartproduct")]
    public class CartProductDTO
    {
        public Guid Id {get; set; }
        public Guid CartDTOId { get; set; }
        public Guid ProductId { get; set; }
    }
}