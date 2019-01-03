using AutoMapper;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.Models.Customers;
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

            //Mapper.CreateMap<Cart, CartDto>();
            //Mapper.CreateMap<CartProduct, CartProductDto>();

            //Mapper.CreateMap<Purchase, CheckOutResultDto>().ForMember(x => x.PurchaseId, options => options.MapFrom(x => x.Id));

            //Mapper.CreateMap<CreditCard, CreditCardDto>();

            //Mapper.CreateMap<Product, ProductDto>();
            //Mapper.CreateMap<CustomerPurchaseHistoryReadModel, CustomerPurchaseHistoryDto>();
            //Mapper.CreateMap<DomainEventRecord, EventDto>();
        }
    }
}
