using AutoMapper;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.Users;
using PsscProject.Models.Customers;
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
        }
    }
}
