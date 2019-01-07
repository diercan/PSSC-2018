using PsscProject.Models.Customers;
using PsscProject.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Products
{
    public class Return
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public ReturnReason Reason { get; set; }
        public DateTime Created { get; set; }
        public PlainText Note { get; set; }
    }
}
