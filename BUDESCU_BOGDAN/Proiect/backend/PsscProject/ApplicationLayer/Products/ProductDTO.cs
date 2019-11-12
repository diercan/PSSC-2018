using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Products
{
    [Table("product")]
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Active { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public Guid ProductCodeId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        //public string ProductCodeName { get; set; }
    }
}
