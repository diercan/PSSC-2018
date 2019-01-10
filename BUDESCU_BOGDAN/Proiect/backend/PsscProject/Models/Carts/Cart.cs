using PsscProject.ApplicationLayer.Carts;
using PsscProject.Helpers.Domain;
using PsscProject.Models.Customers;
using PsscProject.Models.Generic;
using PsscProject.Models.Products;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Carts
{
    public class Cart : IAggregateRoot
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Cost TotalCost { get; set; }
        private List<CartProductDTO> cartProducts = new List<CartProductDTO>();
        public ReadOnlyCollection<CartProductDTO> Products
        {
            get { return cartProducts.AsReadOnly(); }
        }
      
        public static Cart Create(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("customer");

            Cart cart = new Cart();
            cart.Id = Guid.NewGuid();
            cart.CustomerId = customer.Id;
            
            //DomainEvents.Raise<CartCreated>(new CartCreated() { Cart = cart });

            return cart;
        }

        public void Add(CartProductDTO cartProduct)
        {
            if (cartProduct == null)
                throw new ArgumentNullException();

            //DomainEvents.Raise<ProductAddedCart>(new ProductAddedCart() { CartProductDTO = cartProduct });

            this.cartProducts.Add(cartProduct);
        }

        public void Remove(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            //CartProductDTO cartProduct = this.cartProducts.FindO();

            //DomainEvents.Raise<ProductRemovedCart>(new ProductRemovedCart() { CartProductDTO = cartProduct });

            //this.cartProducts.Remove(cartProduct);
        }

        public void Clear()
        {
            this.cartProducts.Clear();
        }
    }
}
