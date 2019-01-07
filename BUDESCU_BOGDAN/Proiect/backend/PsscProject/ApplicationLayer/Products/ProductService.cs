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
    public class ProductService:IProductService
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
            this.productRepository.Create(productDto);
            this.productRepository.Save();
            return productDto;
        }

        public ProductDTO Get(Guid productId)
        {
            ProductDTO product = this.productRepository.FindOne(c => c.Id == productId);
            return product;
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            IEnumerable<ProductDTO> products = this.productRepository.FindAll();
            return products;
        }

        public void Update(ProductDTO productDto)
        {
            if (productDto.Id == Guid.Empty)
            {
                throw new Exception("Id can't be empty");
            }
            ProductDTO product = this.productRepository.FindOne(c => c.Id == productDto.Id);

            if (product == null)
            {
                throw new Exception("No such product exists");
            }
            product.Active = productDto.Active;
            product.Cost = productDto.Cost;
            product.Name = productDto.Name;
            product.Quantity = productDto.Quantity;
            this.productRepository.Update(product);
            this.productRepository.Save();
        }

        public void Remove(Guid productId)
        {
            ProductDTO product = this.productRepository.FindOne(c => c.Id == productId);

            if (product == null)
            {
                throw new Exception("No such product exists");
            }

            this.productRepository.Delete(product);
            this.productRepository.Save();
        }
    }
}
