using PsscProject.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Customers
{
    public interface ICustomerService
    {
        bool IsEmailAvailable(string email);
        Customer Add(CustomerDTO customerDto);
        void Update(CustomerDTO customerDto);
        void Remove(Guid customerId);
        CustomerDTO Get(Guid customerId);
        IEnumerable<CustomerDTO> GetAll();
        CreditCardDTO Add(Guid customerId, CreditCardDTO creditCard);
        List<CustomerPurchaseHistoryDTO> GetAllCustomerPurchaseHistory();
    }
}
