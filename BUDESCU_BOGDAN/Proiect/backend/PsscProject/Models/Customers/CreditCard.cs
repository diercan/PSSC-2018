using PsscProject.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class CreditCard
    {
        public Guid Id { get; set; }
        public PlainText NameOnCard { get; set; }
        public PlainText CardNumber { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expiry { get; set; }
        public Customer Customer { get; set; }

        public static CreditCard Create(PlainText nameOnCard, PlainText cardNumber, DateTime created,DateTime expiry,Customer customer)
        {
            CreditCard creditCard = new CreditCard()
            {
                Id = Guid.NewGuid(),
                NameOnCard = nameOnCard,
                CardNumber = cardNumber,
                Created = created,
                Expiry = expiry,
                Customer = customer
            };

            return creditCard;
        }
    }
}
