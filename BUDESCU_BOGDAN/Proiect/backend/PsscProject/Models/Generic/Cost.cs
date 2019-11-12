using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Generic
{
    public class Cost
    {
        [Required]
        public decimal Value { get; }

        public Cost(decimal value)
        {
            if (value < 0) throw new ArgumentNullException("invalid value for Cost");

            Value = value;
        }
    }
}
