using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Countries
{
    public class Country : IAggregateRoot
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }

        public static Country Create( string name)
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
