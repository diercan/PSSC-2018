using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PsscProject.ApplicationLayer.Carts;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.Products;
using PsscProject.Helpers.Domain;
using PsscProject.Models.Customers;
using PsscProject.Models.Users;

namespace PsscProject.Commands
{
    public class CommandService : ICommandsService
    {
        public CartDTO AddCart(Guid customerId, CartProductDTO cartProductDto)
        {
            throw new NotImplementedException();
        }

        public CreditCardDTO AddCreditCard(Guid customerId, CreditCardDTO creditCard)
        {
            throw new NotImplementedException();
        }

        public Customer AddCustomer(CustomerDTO customerDto)
        {
            throw new NotImplementedException();
        }

        public void AddEvent<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : DomainEvent
        {
            throw new NotImplementedException();
        }

        public ProductDTO AddProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public User Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public CheckOutResultDTO CheckOut(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public User Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public CartDTO RemoveCart(Guid customerId, Guid productId)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid UpdateCustomer(CustomerDTO customerDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(ProductDTO productDto)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user, string password = null)
        {
            throw new NotImplementedException();
        }
    }
}
