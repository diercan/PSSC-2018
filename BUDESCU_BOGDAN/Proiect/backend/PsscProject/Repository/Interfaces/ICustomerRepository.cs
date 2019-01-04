using PsscProject.ApplicationLayer.Customers;
using PsscProject.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository.Interfaces
{
    public interface ICustomerRepository : IRepositoryBase<CustomerDTO>
    {
        //IEnumerable<CustomerPurchaseHistoryReadModel> GetCustomersPurchaseHistory();
    }
}
