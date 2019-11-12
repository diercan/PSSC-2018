using PsscProject.ApplicationLayer.Products;
using PsscProject.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository.Interfaces
{
    public interface IProductRepository : IRepositoryBase<ProductDTO>
    {
    }
}
