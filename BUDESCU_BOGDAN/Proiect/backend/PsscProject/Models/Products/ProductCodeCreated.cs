using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Products
{
    public class ProductCodeCreated : DomainEvent
    {
        public ProductCode productCode { get; set; }

        public ProductCodeCreated(ProductCode productCode)
        {
            this.Args.Add("Cpde", productCode.Name);
        }
    }
}
