using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Customers
{
    public class CreditCardDTO
    {
        public Guid Id { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public DateTime Expiry { get; set; }
    }
}
