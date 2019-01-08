using System;
using ProiectPSSC.Domain.Factories.Interfaces;
using ProiectPSSC.Domain.Models;

namespace ProiectPSSC.Domain.Factories
{
    public class OrderBuilder : IOrderBuilder
    {
        private readonly Order _order;

        public OrderBuilder(string clientName, string email, string phone, int laptopId, DateTime createdDate)
        {
            _order = new Order(clientName, email, phone, laptopId, createdDate);
        }

        public Order Build()
        {
            return _order;
        }

        public void SetAddress(string address)
        {
            _order.Address = address;
        }

        public void SetLaptopId(int laptopId)
        {
            _order.LaptopId = laptopId;
        }

        public void SetClientName(string name)
        {
            _order.ClientName = name;
        }

        public void SetEmail(string email)
        {
            _order.Email = email;
        }

        public void SetPhone(string phone)
        {
            _order.Phone = phone;
        }
    }
}
