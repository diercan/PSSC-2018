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
        private RepositoryContext _repoContext;
        private ICustomerRepository customerRepository;
        private readonly IMapper _mapper;
        // private IRepositoryBase<Country> countryRepository;
        // private IRepositoryBase<Purchase> purchaseRepository;
     
        public CustomerService(RepositoryContext repositoryContext, IMapper mapper)
        {
            _mapper = mapper;
            _repoContext = repositoryContext;
            customerRepository = new CustomerRepository(_repoContext);
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

        public CustomerDTO Add(CustomerDTO customerDto)
        {
            //Customer existingCustomer = this.customerRepository.FindOne(c => c.Email == customerDto.Email);

            //if (existingCustomer != null)
            //{
            //   throw new Exception("Customer with this email already exists");
            //}

            Country country = Country.Create("Romania");
            Customer customer = Customer.Create(customerDto.FirstName, customerDto.LastName, customerDto.Email, country);

            this.customerRepository.Create(customer);
            this.customerRepository.Save();
            return _mapper.Map<Customer, CustomerDTO>(customer);
        }

        public void Update(CustomerDTO customerDto)
        {
            if (customerDto.Id == Guid.Empty)
            {
                throw new Exception("Id can't be empty");
            }
            Customer customer = this.customerRepository.FindOne(c => c.Id == customerDto.Id);

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
            Customer customer = this.customerRepository.FindOne(c => c.Id == customerId);

            if (customer == null)
            {
                throw new Exception("No such customer exists");
            }

            this.customerRepository.Delete(customer);
            this.customerRepository.Save();
        }

        public CustomerDTO Get(Guid customerId)
        {
            Customer customer = customerRepository.FindOne(c => c.Id == customerId);
            return _mapper.Map<Customer, CustomerDTO>(customer);
        }

        public List<CustomerDTO> GetAll()
        {
            IEnumerable<Customer> customer = this.customerRepository.FindAll();
            return _mapper.Map<IEnumerable<Customer>, List<CustomerDTO>>(customer);
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

        //Approach 2 - Infrastructure Read Model Projection (Preferred)
        public List<CustomerPurchaseHistoryDTO> GetAllCustomerPurchaseHistory()
        {
            //IEnumerable<CustomerPurchaseHistoryReadModel> customersPurchaseHistory =
            //    this.customerRepository.GetCustomersPurchaseHistory();

            //return AutoMapper.Mapper.Map<IEnumerable<CustomerPurchaseHistoryReadModel>, List<CustomerPurchaseHistoryDto>>(customersPurchaseHistory);
            return null;
        }
    }
}
