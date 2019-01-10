using PsscProject.ApplicationLayer.Customers;
using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class CustomerUpdated : DomainEvent
    {
        public CustomerDTO Customer { get; set; }

        public CustomerUpdated(CustomerDTO customer )
        {
            this.Args.Add("FirstName", customer.FirstName);
            this.Args.Add("LastName", customer.LastName);
            this.Args.Add("Email", customer.Email);
        }
    }
}
