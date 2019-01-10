using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PsscProject.ApplicationLayer.Carts;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.Products;

namespace PsscProject.Queries
{
    public class QueriesService : IQueriesService
    {
        public IEnumerable<CustomerDTO> GetAllCustomer()
        {
            throw new NotImplementedException();
        }

        public List<CustomerPurchaseHistoryDTO> GetAllCustomerPurchaseHistory()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public CartDTO GetCart(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CreditCardDTO> GetCreditCardsById(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public CustomerDTO GetCustomer(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public CustomerDTO GetCustomerByUserId(Guid UserId)
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetProduct(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
