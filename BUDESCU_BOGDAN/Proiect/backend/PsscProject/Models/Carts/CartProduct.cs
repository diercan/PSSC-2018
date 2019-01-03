using PsscProject.Models.Customers;
using PsscProject.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Carts
{
    public class CartProduct
    {
        public Guid CartId { get; protected set; }
        public Guid CustomerId { get; protected set; }
        public int Quantity { get; protected set; }
        public Guid ProductId { get; protected set; }
        public DateTime Created { get; protected set; }
        public decimal Cost { get; protected set; }
        public decimal Tax { get; set; }

        public static CartProduct Create(Customer customer, Cart cart, Product product, int quantity/*, TaxService taxService*/)
        {
            CartProduct cartProduct = new CartProduct()
            {
                CustomerId = customer.Id,
                CartId = cart.Id,
                ProductId = product.Id,
                Quantity = quantity,
                Created = DateTime.Now,
                Cost = product.Cost,
                //Tax = taxService.Calculate(customer, product)
            };

            return cartProduct;
        }
    }
}
