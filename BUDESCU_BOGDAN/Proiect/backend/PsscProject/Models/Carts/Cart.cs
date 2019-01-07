using PsscProject.Helpers.Domain;
using PsscProject.Models.Customers;
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
        public Guid Id { get; protected set; }

        private List<CartProduct> cartProducts = new List<CartProduct>();

        public ReadOnlyCollection<CartProduct> Products
        {
            get { return cartProducts.AsReadOnly(); }
        }

        public Guid CustomerId { get; protected set; }

        public decimal TotalCost
        {
            get
            {
                return this.Products.Sum(cartProduct => cartProduct.Quantity * cartProduct.Cost);
            }
        }

        public decimal TotalTax
        {
            get
            {
                return this.Products.Sum(cartProducts => cartProducts.Tax);
            }
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

        public void Add(CartProduct cartProduct)
        {
            if (cartProduct == null)
                throw new ArgumentNullException();

            //DomainEvents.Raise<ProductAddedCart>(new ProductAddedCart() { CartProduct = cartProduct });

            this.cartProducts.Add(cartProduct);
        }

        public void Remove(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            CartProduct cartProduct = null;
                //= this.cartProducts.Find(new ProductInCartSpec(product).IsSatisfiedBy);

            //DomainEvents.Raise<ProductRemovedCart>(new ProductRemovedCart() { CartProduct = cartProduct });

            this.cartProducts.Remove(cartProduct);
        }

        public void Clear()
        {
            this.cartProducts.Clear();
        }
    }
}
