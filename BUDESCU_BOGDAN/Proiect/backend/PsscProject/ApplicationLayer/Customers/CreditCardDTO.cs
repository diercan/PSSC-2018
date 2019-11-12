using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Customers
{
    [Table("CreditCard")]
    public class CreditCardDTO
    {
        public Guid Id { get; set; }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public DateTime Expiry { get; set; }
        public Guid CustomerDTOId { get; set; }
    }
}
