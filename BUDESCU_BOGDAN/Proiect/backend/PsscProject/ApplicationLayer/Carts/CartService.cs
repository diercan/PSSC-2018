using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Carts
{
    public class CartService 
    {
        private ICustomerRepository customerRepository;
        private IProductRepository productRepository;
        private ICartRepository cartRepository;
        public CartService(
            ICustomerRepository customerRepository,
            IProductRepository productRepository, 
            ICartRepository cartRepository)
        {
            this.customerRepository = customerRepository;
            this.productRepository = productRepository;
            this.cartRepository = cartRepository;
        }

    }
}
