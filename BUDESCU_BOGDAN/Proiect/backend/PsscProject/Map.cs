using AutoMapper;
using PsscProject.ApplicationLayer.Carts;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.History;
using PsscProject.ApplicationLayer.Products;
using PsscProject.ApplicationLayer.Users;
using PsscProject.Helpers.Domain;
using PsscProject.Models.Carts;
using PsscProject.Models.Customers;
using PsscProject.Models.Products;
using PsscProject.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject
{
    public class Map : Profile
    {
        public Map()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            CreateMap<Cart, CartDTO>();
            CreateMap<CartDTO, Cart>();
            CreateMap<DomainEventRecord, EventDTO>();
            CreateMap<EventDTO, DomainEventRecord>();
        }
    }
}
