using System;
using ProiectPSSC.Domain.Services.Entities;

namespace ProiectPSSC.Domain.Models
{
    public class Order : OrderEntity
    {
        public Order(string clientName, string email, string phone, int laptopId, DateTime createdDate) : base(createdDate)
        {
            this.ClientName = clientName;
            this.Email = email;
            this.Phone = phone;
            this.LaptopId = laptopId;
        }

        public string ClientName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int LaptopId { get; set; }
    }
}
