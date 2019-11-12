using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class Email:ValueObject
    {
        [Required, EmailAddress]
        public string Value { get; }

        public Email(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("email input cannot be null or empty");
            if (!value.Contains("@")) throw new ArgumentException("Email is invalid");

            Value = value;
        }

    }
}
