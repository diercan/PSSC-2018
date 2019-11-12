using PsscProject.Helpers.Domain;
using PsscProject.Models.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class Address : ValueObject
    {
        [Required]
        public PlainText Street { get; }
        [Required]
        public PlainText City { get; }
        [Required]
        public PlainText ZipCode { get; }
        public Address(PlainText street, PlainText city, PlainText zipCode)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
        }
    }
}
