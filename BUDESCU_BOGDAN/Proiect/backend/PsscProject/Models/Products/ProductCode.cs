using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Products
{
    public class ProductCode : IAggregateRoot
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
     
        public static ProductCode Create(string name)
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
