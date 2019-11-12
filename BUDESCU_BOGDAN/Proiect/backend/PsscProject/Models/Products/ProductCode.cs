using PsscProject.Helpers.Domain;
using PsscProject.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Products
{
    public class ProductCode : IAggregateRoot
    {
        public Guid Id { get; protected set; }
        public PlainText Name { get; protected set; }
     
        public static ProductCode Create(PlainText name)
        {
            ProductCode productCode = new ProductCode()
            {
                Id = Guid.NewGuid(),
                Name = name
            };

            return productCode;
        }
    }
}
