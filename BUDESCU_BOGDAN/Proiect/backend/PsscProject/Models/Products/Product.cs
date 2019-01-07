using PsscProject.Helpers.Domain;
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
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Active { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public ProductCode Code { get; set; }
        public ReadOnlyCollection<Return> Returns
        {
            get
            {
                return returns.AsReadOnly();
            }
        }

        public static Product Create(string name, int quantity, int cost, ProductCode productCode)
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
                Code = productCode
            };

            return product;
        }
    }
}
