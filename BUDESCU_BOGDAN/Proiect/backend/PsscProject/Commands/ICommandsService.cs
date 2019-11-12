using System;
using PsscProject.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.Products;
using PsscProject.Models.Users;
using PsscProject.ApplicationLayer.Carts;
using PsscProject.Helpers.Domain;

namespace PsscProject.Commands
{
    interface ICommandsService
    {
        Customer AddCustomer(CustomerDTO customerDto);
        Guid UpdateCustomer(CustomerDTO customerDto);
        void RemoveCustomer(Guid customerId);
        CreditCardDTO AddCreditCard(Guid customerId, CreditCardDTO creditCard);
        ProductDTO AddProduct(ProductDTO product);
        void UpdateProduct(ProductDTO productDto);
        void RemoveProduct(Guid id);
        User Authenticate(string username, string password);
        User Register(User user, string password);
        void UpdateUser(User user, string password = null);
        void AddEvent<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : DomainEvent;
        CartDTO AddCart(Guid customerId, CartProductDTO cartProductDto);
        CartDTO RemoveCart(Guid customerId, Guid productId);
        CheckOutResultDTO CheckOut(Guid customerId);
    }
}
