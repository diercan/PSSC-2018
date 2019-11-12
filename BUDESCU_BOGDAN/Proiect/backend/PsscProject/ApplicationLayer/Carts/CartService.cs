using AutoMapper;
using Newtonsoft.Json;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.Products;
using PsscProject.Models.Carts;
using PsscProject.Models.Countries;
using PsscProject.Models.Customers;
using PsscProject.Models.Generic;
using PsscProject.Models.Products;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Carts
{
    public class CartService :ICartService
    {
        private ICustomerRepository customerRepository;
        private IProductRepository productRepository;
        private ICartRepository cartRepository;
        private readonly IMapper _mapper;

        public CartService(
            ICustomerRepository customerRepository,
            IProductRepository productRepository, 
            ICartRepository cartRepository,
            IMapper mapper
            )
        {
            this.customerRepository = customerRepository;
            this.productRepository = productRepository;
            this.cartRepository = cartRepository;
            this._mapper = mapper;
        }

        public CartDTO Add(Guid customerId, CartProductDTO cartProductDto)
        {
            CartDTO cartDto = null;
            Cart cart = null;
          
            CustomerDTO customerDto = this.customerRepository.FindOne(c => c.Id == customerId);
            if (customerDto == null)
                throw new Exception(String.Format("Customer was not found with this Id: {0}", customerId));

            Customer customer = Customer.Create(
                  new PlainText(customerDto.FirstName),
                  new PlainText(customerDto.LastName),
                  new Email(customerDto.Email),
                   Country.Create(new PlainText("Romania"))
                  );

            cartDto = this.cartRepository.FindOne(c=> c.CustomerId == customerId);
            if (cartDto == null)
            {
                cart = Cart.Create(customer);
            } else
            {
                cart = new Cart()
                {
                    CustomerId = customerId,
                    Id = cartDto.Id
                };

                //foreach(var cardP in cartDto.Products)
                //{
                //    cart.Add(cardP);
                //}
            }

            ProductDTO productDto = this.productRepository.FindOne(c => c.Id == cartProductDto.ProductId);
            Product product = Product.Create(
                new PlainText(productDto.Name),
                new Quantity(productDto.Quantity),
                new Cost(productDto.Cost),
                ProductCode.Create(new PlainText("test")),
                new PlainText(productDto.Description),
                productDto.Image
                );

            var cartP = CartProduct.Create(customer, cart, product, new Quantity(1));

            cart.Add(new CartProductDTO(){
                    Id =cartP.Id,
                    CartDTOId = cart.Id,
                    ProductId = cartP.ProductId
            });
            Console.WriteLine(JsonConvert.SerializeObject(cart));
            // cartDto = _mapper.Map<Cart, CartDTO>(cart);
            cartDto = new CartDTO()
            {
                Created = DateTime.Today,
                CustomerId = customerId,
                Modified = DateTime.Today,
                Id  = cart.Id,
                Products = cart.Products.ToList()
            };
            this.cartRepository.Create(cartDto);
            this.cartRepository.Save();

            return cartDto;
        }

        public CartDTO Remove(Guid customerId, Guid productId)
        {
            throw new NotImplementedException();
        }

        public CartDTO Get(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public CheckOutResultDTO CheckOut(Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
