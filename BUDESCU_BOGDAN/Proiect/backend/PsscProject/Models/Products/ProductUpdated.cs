using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Products
{
    public class ProductUpdated : DomainEvent
    {
        public Product product { get; set; }

        public ProductUpdated(Product product)
        {
            this.Args.Add("Name", product.Name.Text.ToString());
            this.Args.Add("Description", product.Description.Text.ToString());
            this.Args.Add("Quantity", product.Quantity.Value.ToString());
            this.Args.Add("Cost", product.Cost.Value.ToString());
        }
    }
}
