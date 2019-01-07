using PsscProject.Helpers.Domain;
using PsscProject.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Countries
{
    public class Country : IAggregateRoot
    {
        public Guid Id { get; protected set; }
        public PlainText Name { get; protected set; }

        public static Country Create(PlainText name)
        {
            Country country = new Country()
            {
                Id = Guid.NewGuid(),
                Name = name
            };

            return country;
        }
    }
}
