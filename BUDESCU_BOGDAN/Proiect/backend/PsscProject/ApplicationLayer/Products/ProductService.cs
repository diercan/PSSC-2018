using AutoMapper;
using PsscProject.Models.Products;
using PsscProject.Repository;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Products
{
    public class ProductService
    {
        private RepositoryContext _repoContext;
        private IProductRepository productRepository;
        private readonly IMapper _mapper;
        public ProductService(RepositoryContext repositoryContext, IMapper mapper)
        {
            _mapper = mapper;
            _repoContext = repositoryContext;
            productRepository = new ProductRepository(_repoContext);
        }

        public ProductDTO Add(ProductDTO productDto)
        {
            ProductCode productCode = ProductCode.Create("cod");
            Product product = Product.Create(productDto.Name, productDto.Quantity, productDto.Cost, productCode);

            this.productRepository.Create(product);
            this.productRepository.Save();
            return _mapper.Map<Product, ProductDTO>(product);
        }

        public ProductDTO Get(Guid productId)
        {
            Product product = this.productRepository.FindOne(c => c.Id == productId);
            return _mapper.Map<Product, ProductDTO>(product);
        }

        public List<ProductDTO> GetAll()
        {
            IEnumerable<Product> product = this.productRepository.FindAll();
            return _mapper.Map<IEnumerable<Product>, List<ProductDTO>>(product);
        }
    }
}
