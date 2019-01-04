using PsscProject.Helpers.Domain;
using PsscProject.Models.Countries;
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public Guid CountryId { get; set; }
        public ReadOnlyCollection<CreditCard> CreditCards { get { return this.creditCards.AsReadOnly(); } }

        public static Customer Create(string firstname, string lastname, string email, Country country)
        {
            Customer customer = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                CountryId = country.Id
            };

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
