using PsscProject.Helpers.Domain;
using PsscProject.Models.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Products
{
    public class Product : IAggregateRoot
    {
        private List<Return> returns = new List<Return>();

        public Guid Id { get; set; }
        public PlainText Name { get; set; }
        public PlainText Details { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Active { get; set; }
        public Quantity Quantity { get; set; }
        public Cost Cost { get; set; }
        public ProductCode Code { get; set; }
        public PlainText Description { get; set; }
        public string Image { get; set; }
        public ReadOnlyCollection<Return> Returns
        {
            get
            {
                return returns.AsReadOnly();
            }
        }

        public static Product Create(PlainText name,  Quantity quantity, Cost cost, ProductCode productCode, PlainText description, string image)
        {
            Product product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Quantity = quantity,
                Created = DateTime.Now,
                Modified = DateTime.Now,
                Active = true,
                Cost = cost,
                Code = productCode,
                Description = description,
                Image = image
            };

            DomainEvents.Raise<ProductCreated>(new ProductCreated(product));
            return product;
        }
    }
}
