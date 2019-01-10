using PsscProject.Helpers.Domain;
using PsscProject.Models.Customers;
using PsscProject.Models.Generic;
using PsscProject.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Carts
{
    public class CartProduct: IAggregateRoot
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }

        public Quantity Quantity { get; set; }
        public DateTime Created { get; set; }
        public Cost Cost { get; set; }
        public decimal Tax { get; set; }

        public static CartProduct Create(Customer customer, Cart cart, Product product, Quantity quantity /*, TaxService taxService*/)
        {
            CartProduct cartProduct = new CartProduct()
            {
                Id = Guid.NewGuid(),
                CustomerId = customer.Id,
                CartId = cart.Id,
                ProductId = product.Id,
                Quantity = quantity,
                Created = DateTime.Now,
                Cost = product.Cost,
            };

            return cartProduct;
        }
    }
}
