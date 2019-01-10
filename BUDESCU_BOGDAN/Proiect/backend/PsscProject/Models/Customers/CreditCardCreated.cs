using Newtonsoft.Json;
using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class CreditCardCreated : DomainEvent
    {
        public CreditCard creditCard { get; set; }

        public CreditCardCreated(CreditCard creditCard)
        {
            this.Args.Add("CardNumber", creditCard.CardNumber);
            this.Args.Add("NameOnCard", creditCard.NameOnCard);
            this.Args.Add("Expiry", creditCard.Expiry);
            this.Args.Add("Customer", JsonConvert.SerializeObject(creditCard.Customer));
        }
    }
}
