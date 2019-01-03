using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class CreditCard
    {
        public Guid Id { get; protected set; }
        public string NameOnCard { get; protected set; }
        public string CardNumber { get; protected set; }
        public bool Active { get; protected set; }
        public DateTime Created { get; protected set; }
        public DateTime Expiry { get; protected set; }
        public Customer Customer { get; protected set; }
    }
}
