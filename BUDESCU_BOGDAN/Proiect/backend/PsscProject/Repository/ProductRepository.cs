﻿using PsscProject.ApplicationLayer.Products;
using PsscProject.Models.Products;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository
{
    public class ProductRepository : RepositoryBase<ProductDTO>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
