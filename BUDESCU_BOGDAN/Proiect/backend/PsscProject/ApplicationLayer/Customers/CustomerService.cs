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

namespace PsscProject.ApplicationLayer.Customers
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository;
        private readonly IMapper _mapper;
     
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _mapper = mapper;
            this.customerRepository = customerRepository;
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
            Country country = Country.Create("Romania");
            Customer customer = Customer.Create(customerDto.FirstName, customerDto.LastName, customerDto.Email, country);

            this.customerRepository.Create(_mapper.Map<Customer, CustomerDTO>(customer));
            this.customerRepository.Save();
            return customer;
        }

        public void Update(CustomerDTO customerDto)
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
            this.customerRepository.Update(customer);
            this.customerRepository.Save();
        }

        public void Remove(Guid customerId)
        {
            CustomerDTO customer = this.customerRepository.FindOne(c => c.Id == customerId);

            if (customer == null)
            {
                throw new Exception("No such customer exists");
            }

            this.customerRepository.Delete(customer);
            this.customerRepository.Save();
        }

        public CustomerDTO Get(Guid customerId)
        {
            CustomerDTO customer = customerRepository.FindOne(c => c.Id == customerId);
            return customer;
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            IEnumerable<CustomerDTO> customers = this.customerRepository.FindAll();
            return customers;
        }

        public CreditCardDTO Add(Guid customerId, CreditCardDTO creditCardDto)
        {
            //ISpecification<Customer> registeredSpec =
            //    new CustomerRegisteredSpec(customerId);

            //Customer customer = this.customerRepository.FindOne(registeredSpec);

            //if (customer == null)
            //    throw new Exception("No such customer exists");

            //CreditCard creditCard =
            //    CreditCard.Create(customer, creditCardDto.NameOnCard,
            //    creditCardDto.CardNumber, creditCardDto.Expiry);

            //customer.Add(creditCard);

            //return AutoMapper.Mapper.Map<CreditCard, CreditCardDTO>(creditCard);
            return null;
        }

        public List<CustomerPurchaseHistoryDTO> GetAllCustomerPurchaseHistory()
        {
            //IEnumerable<CustomerPurchaseHistoryReadModel> customersPurchaseHistory =
            //    this.customerRepository.GetCustomersPurchaseHistory();

            //return AutoMapper.Mapper.Map<IEnumerable<CustomerPurchaseHistoryReadModel>, List<CustomerPurchaseHistoryDto>>(customersPurchaseHistory);
            return null;
        }
    }
}
