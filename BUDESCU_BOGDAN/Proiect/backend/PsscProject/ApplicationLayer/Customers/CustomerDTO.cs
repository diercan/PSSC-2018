using PsscProject.ApplicationLayer.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Customers
{
    [Table("customer")]
    public class CustomerDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public UserDTO User { get; set; }
        public ICollection<CreditCardDTO> CreditCards { get; set; } = new List<CreditCardDTO> { };
    }
}
