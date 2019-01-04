using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class CreditCard
    {
        public Guid Id { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expiry { get; set; }
        public Customer Customer { get; set; }
    }
}
