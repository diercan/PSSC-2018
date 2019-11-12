using PsscProject.ApplicationLayer.Carts;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Queries
{
    interface IQueriesService
    {
        CustomerDTO GetCustomer(Guid customerId);
        IEnumerable<CustomerDTO> GetAllCustomer();
        List<CustomerPurchaseHistoryDTO> GetAllCustomerPurchaseHistory();
        IEnumerable<CreditCardDTO> GetCreditCardsById(Guid customerId);
        CustomerDTO GetCustomerByUserId(Guid UserId);
        CartDTO GetCart(Guid customerId);
        ProductDTO GetProduct(Guid productId);
        IEnumerable<ProductDTO> GetAllProduct();
    }
}
