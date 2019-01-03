using PsscProject.Helpers.Domain;
using PsscProject.Models.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Tax
{
    public class CountryTax : IAggregateRoot
    {
        public Guid Id { get; protected set; }
        public Country Country { get; protected set; }
        public decimal Percentage { get; protected set; }
        public TaxType Type { get; protected set; }

        public static CountryTax Create(Guid id, TaxType type, Country country, decimal percentage)
        {
            CountryTax countryTax = new CountryTax()
            {
                Id = Guid.NewGuid(),
                Country = country,
                Percentage = percentage,
                Type = type
            };

            //DomainEvents.Raise<CountryTaxCreated>(new CountryTaxCreated() { CountryTax = countryTax });

            return countryTax;
        }
    }
}
