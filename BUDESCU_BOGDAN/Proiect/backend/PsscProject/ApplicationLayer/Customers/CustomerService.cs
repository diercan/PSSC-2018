using PsscProject.Models.Countries;
using PsscProject.Models.Customers;
using PsscProject.Models.Purchases;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PsscProject.Repository;
using Newtonsoft.Json;
using PsscProject.Models.Generic;
using System.Collections.ObjectModel;
using PsscProject.ApplicationLayer.Users;
using PsscProject.Models.Users;
using PsscProject.Helpers.Domain;

namespace PsscProject.ApplicationLayer.Customers
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository;
        private IUserRepository userRepository;
        private IUserService userService;
        private ICreditCardRepository creditCardRepository;
        private readonly IMapper _mapper;
     
        public CustomerService(ICustomerRepository customerRepository, ICreditCardRepository creditCardRepository,IUserRepository userRepository, IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            this.customerRepository = customerRepository;
            this.creditCardRepository = creditCardRepository;
            this.userRepository = userRepository;
            this.userService = userService;
        }

        public bool IsEmailAvailable(string email)
        {
            var existingCustomer = customerRepository.FindByCondition(customer => customer.Email == email) as Customer;

            if (existingCustomer == null)
            {
                return true;
            }

            return false;
        }

        public Customer Add(CustomerDTO customerDto)
        {
            Country country = Country.Create(new PlainText("Romania"));
            Customer customer = Customer.Create(new PlainText(customerDto.FirstName), new PlainText(customerDto.LastName), new Email(customerDto.Email), country);

            this.customerRepository.Create(customerDto);
            this.customerRepository.Save();
            return customer;
        }

        public Guid Update(CustomerDTO customerDto)
        {
            if (customerDto.Id == Guid.Empty)
            {
                throw new Exception("Id can't be empty");
            }
            CustomerDTO customer = this.customerRepository.FindOne(c => c.Id == customerDto.Id);

            if (customer == null)
            {
                throw new Exception("No such customer exists");
            }
            customer.Email = customerDto.Email;
            customer.FirstName = customerDto.FirstName;
            customer.LastName = customerDto.LastName;
            customer.ZipCode = customerDto.ZipCode;
            customer.Street = customerDto.Street;
            customer.City = customerDto.City;
            this.customerRepository.Update(customer);
            this.customerRepository.Save();
            DomainEvents.Raise<CustomerUpdated>(new CustomerUpdated(customer));
            return customer.UserId;
        }

        public void Remove(Guid customerId)
        {
            CustomerDTO customer = this.customerRepository.FindOne(c => c.Id == customerId);

            if (customer == null)
            {
                throw new Exception("No such customer exists");
            }
            DomainEvents.Raise<CustomerDeleted>(new CustomerDeleted(customer));
            this.customerRepository.Delete(customer);
            this.customerRepository.Save();
        }

        public CustomerDTO Get(Guid customerId)
        {
            CustomerDTO customer = customerRepository.FindOne(c => c.Id == customerId);
            customer.CreditCards = GetCreditCardsById(customerId).ToList();
            return customer;
        }

        public IEnumerable<CreditCardDTO> GetCreditCardsById(Guid customerId)
        {
            IEnumerable<CreditCardDTO> creditsCard = creditCardRepository.FindByCondition(c => c.CustomerDTOId == customerId);
            return creditsCard;
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            IEnumerable<CustomerDTO> customers = this.customerRepository.FindAll();
            try
            {
                foreach (var c in customers)
                {
                    var user = userRepository.FindOne(r => r.Id == c.UserId);
                    c.User = new UserDTO()
                    {
                        Username = user.UserName,
                        Role = user.Role
                    };
                }
            } catch(Exception ex) { }
            return customers;
        }

        public CustomerDTO GetCustomerByUserId(Guid UserId)
        {
            CustomerDTO customer = customerRepository.FindOne(c => c.UserId == UserId);
            Console.WriteLine(UserId);
            var user = userRepository.FindOne(r => r.Id == customer.UserId);
            customer.User = new UserDTO()
            {
                Username = user.UserName,
                Role = user.Role
            };
            return customer;
        }

        public CreditCardDTO Add(Guid customerId, CreditCardDTO creditCard)
        {
            throw new NotImplementedException();
        }

        public List<CustomerPurchaseHistoryDTO> GetAllCustomerPurchaseHistory()
        {
            throw new NotImplementedException();
        }
    }
}
