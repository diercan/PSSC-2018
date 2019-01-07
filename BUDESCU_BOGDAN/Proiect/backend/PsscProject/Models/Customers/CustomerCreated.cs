using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class CustomerCreated : DomainEvent
    {
        public Customer Customer { get; set; }

        public CustomerCreated(Customer customer )
        {
            this.Args.Add("FirstName", customer.FirstName);
            this.Args.Add("LastName", customer.LastName);
            this.Args.Add("Email", customer.Email);
            this.Args.Add("Country", customer.CountryId);
        }
    }
}
