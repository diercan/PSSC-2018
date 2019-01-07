using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Carts
{
    public enum CheckOutIssue
    {
        UnpaidBalance,
        NoActiveCreditCardAvailable,
        ProductNotInStock ,
        ProductIsFaulty,
    }
}
