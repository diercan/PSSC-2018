using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Generic
{
    public class Quantity
    {
        [Required]
        public int Value { get; }

        public Quantity(int value)
        {
            if (value < 0) throw new ArgumentNullException("invalid value for Quantity");

            Value = value;
        }
    }
}
