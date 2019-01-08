using System.Collections.Generic;
using ProiectPSSC.Domain.Models;

namespace ProiectPSSC.Domain.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        List<Order> QueryOrders();
    }
}
