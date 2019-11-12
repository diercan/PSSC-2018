using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Carts
{
    public class CheckOutResultDTO
    {
        public Guid PurchaseId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalTax { get; set; }
        public CheckOutIssue CheckOutIssue { get; set; }
    }
}
