using PsscProject.ApplicationLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Carts
{
    public interface ICartService
    {
        CartDTO Add(Guid customerId, CartProductDTO cartProductDto);
        CartDTO Remove(Guid customerId, Guid productId);
        CartDTO Get(Guid customerId);
        CheckOutResultDTO CheckOut(Guid customerId);
    }
}
