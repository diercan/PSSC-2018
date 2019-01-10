using PsscProject.ApplicationLayer.Customers;
using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class CustomerDeleted : DomainEvent
    {
        public CustomerDTO Customer { get; set; }

        public CustomerDeleted(CustomerDTO customer )
        {
            this.Args.Add("FirstName", customer.FirstName);
            this.Args.Add("LastName", customer.LastName);
            this.Args.Add("Email", customer.Email);
        }
    }
}
