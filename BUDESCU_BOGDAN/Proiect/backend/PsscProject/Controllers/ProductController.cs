using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PsscProject.ApplicationLayer.Carts;
using PsscProject.ApplicationLayer.Products;

namespace PsscProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICartService _cartService;
        public ProductController(IProductService productService, ICartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
        }

        // GET: api/Product
        [HttpGet]
        public IEnumerable<ProductDTO> GetProducts()
        {
            return this._productService.GetAll();
        }

        // GET: api/Product/5
        [HttpGet("{id}"), Authorize]
        public ProductDTO GetPrductById(Guid id)
        {
            return this._productService.Get(id);
        }
        
        // POST: api/Product
        [HttpPost, Authorize]
        public ProductDTO AddProduct([FromBody]JObject value)
        {
            ProductDTO productDTO = new ProductDTO()
            {
                Name = (String)value["name"],
                Created = DateTime.Today,
                Modified = DateTime.Today,
                Active = (Boolean)value["active"],
                Quantity = (Int32)value["quantity"],
                Cost = (Int32)value["cost"],
                Description = (String)value["description"],
                Image = (String)value["image"]
            };
            return this._productService.Add(productDTO);
        }

        [HttpPost("cart/{id}")]
        public CartDTO AddProductToCart(Guid id, [FromBody]JObject value)
        {
            Console.WriteLine(id);
            CartProductDTO productDTO = new CartProductDTO()
            {
                ProductId = (Guid)value["id"]
            };

            return this._cartService.Add(id, productDTO);
        }

        // PUT: api/Product/5
        [HttpPut("{id}"), Authorize]
        public void UpdateProduct(Guid id, [FromBody]JObject value)
        {
            ProductDTO productDTO = new ProductDTO()
            {
                Id = id,
                Name = (String)value["name"],
                Modified = DateTime.Today,
                Active = (Boolean)value["active"],
                Quantity = (Int16)value["quantity"],
                Cost = (Int16)value["cost"],
                Description = (String)value["description"],
                Image = (String)value["image"]
            };
            this._productService.Update(productDTO);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}"), Authorize]
        public void DeleteProduct(Guid id)
        {
            this._productService.Remove(id);
        }
    }
}
