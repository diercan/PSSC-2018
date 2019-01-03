using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Products
{
    public class Product : IAggregateRoot
    {
        private List<Return> returns = new List<Return>();

        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public DateTime Created { get; protected set; }
        public DateTime Modified { get; protected set; }
        public bool Active { get; protected set; }
        public int Quantity { get; protected set; }
        public decimal Cost { get; protected set; }
        public ProductCode Code { get; protected set; }
        public ReadOnlyCollection<Return> Returns
        {
            get
            {
                return returns.AsReadOnly();
            }
        }

        public static Product Create(string name, int quantity, decimal cost, ProductCode productCode)
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
