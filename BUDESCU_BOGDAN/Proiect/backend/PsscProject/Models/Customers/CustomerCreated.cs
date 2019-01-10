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
            this.Args.Add("FirstName", customer.FirstName.Text.ToString());
            this.Args.Add("LastName", customer.LastName.Text.ToString());
            this.Args.Add("Email", customer.Email.Value.ToString());
            this.Args.Add("Country", customer.CountryId.ToString());
        }
    }
}
