using PsscProject.Helpers.Domain;
using PsscProject.Models.Countries;
using PsscProject.Models.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class Customer : IAggregateRoot
    {
        private List<CreditCard> creditCards = new List<CreditCard>();
        public Guid Id { get; set; }
        public PlainText FirstName { get; set; }
        public PlainText LastName { get; set; }
        public Email Email { get; set; }
        public PlainText Password { get; set; }
        public Balance Balance { get; set; }
        public Address Address { get; set; }
        public Guid CountryId { get; set; }
        public ReadOnlyCollection<CreditCard> CreditCards { get { return this.creditCards.AsReadOnly(); } }

        public static Customer Create(PlainText firstname, PlainText lastname, Email email, Country country)
        {
            Customer customer = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                CountryId = country.Id
            };

            DomainEvents.Raise<CustomerCreated>(new CustomerCreated(customer));

            return customer;
        }

        public ReadOnlyCollection<CreditCard> GetCreditCardsAvailble()
        {
            return this.creditCards.FindAll(creditCard => creditCard.Active && creditCard.Expiry >= DateTime.Today).AsReadOnly();
        }

        public void AddCreditCard(CreditCard creditCard)
        {
            this.creditCards.Add(creditCard);
        }
    }
}
