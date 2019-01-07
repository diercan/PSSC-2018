using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Customers
{
    public class Balance:ValueObject
    {
        [Required]
        public int Value { get; }

        public Balance(int value)
        {
            if (value < 0) throw new ArgumentNullException("invalid value for balance");

            Value = value;
        }
    }
}
