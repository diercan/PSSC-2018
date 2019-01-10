using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.History;
using PsscProject.ApplicationLayer.Users;
using PsscProject.Models.Customers;
using PsscProject.Models.Users;

namespace PsscProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;
        private IUserService _userService;
        private IHistoryService _historyService;
        private IMapper _mapper;

        public CustomerController(ICustomerService customerService, IHistoryService historyService, IMapper mapper, IUserService userService)
        {
            _customerService = customerService;
            _historyService = historyService;
            _userService = userService;
            _mapper = mapper;
        }

        // GET: api/Customer
        [HttpGet, Authorize(Roles = "Manager")]
        public IEnumerable<CustomerDTO> Get()
        {
            IEnumerable<CustomerDTO> customerDTOs = this._customerService.GetAll();
           
            return this._customerService.GetAll();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get"), Authorize]
        public CustomerDTO Get(Guid id)
        {
            return this._customerService.GetCustomerByUserId(id);
        }

        // POST: api/Customer
        [HttpPost, Authorize]
        public CustomerDTO Post([FromBody]JObject value)
        {
            UserDTO userDto = new UserDTO()
            {
                Username = (String)value["userName"],
                Password = (String)value["password"],
                Role = "Customer"
            };
            var user = _mapper.Map<User>(userDto);
            var _newUser = _userService.Create(user, userDto.Password);

            CustomerDTO customerDto = new CustomerDTO()
            {
                LastName = (String)value["lastName"],
                FirstName = (String)value["firstName"],
                Email = (String)value["email"],
                City = (String)value["city"],
                Street = (String)value["street"],
                ZipCode = (String)value["zipCode"],
                Country = (String)value["country"],
                UserId = _newUser.Id
            };
            //_mapper.Map<Customer, CustomerDTO>(customer)
            Customer customer = this._customerService.Add(customerDto);
            //this._historyService.AddEvent(new CustomerCreated() { Customer = customer });

            return _mapper.Map<Customer, CustomerDTO>(customer);
        }
        
        // PUT: api/Customer/5
        [HttpPut("{id}"), Authorize]
        public void Put(int id, [FromBody]JObject value)
        {
           
            CustomerDTO customerDto = new CustomerDTO()
            {
                Id = (Guid)value["id"],
                LastName = (String)value["lastName"],
                FirstName = (String)value["firstName"],
                Email = (String)value["email"],
                City = (String)value["city"],
                Street = (String)value["street"],
                ZipCode = (String)value["zipCode"],
                Country = (String)value["country"],
            };
            var userId = this._customerService.Update(customerDto);

            try
            {
                UserDTO userDto = new UserDTO()
                {
                    Id = userId,
                    Username = (String)value["userName"],
                    Password = (String)value["password"],
                    Role = "Customer"
                };
                Console.WriteLine(JsonConvert.SerializeObject(userDto));
                var user = _mapper.Map<User>(userDto);
                _userService.Update(user, userDto.Password);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(userId);
                if (ex.Message == "User not found")
                {
                    UserDTO userDto = new UserDTO()
                    {
                        Username = (String)value["userName"],
                        Password = (String)value["password"],
                        Role = "Customer"
                    };
                    var user = _mapper.Map<User>(userDto);
                    var _newUser = _userService.Create(user, userDto.Password);
                    customerDto.UserId = _newUser.Id;
                    this._customerService.Update(customerDto);
                }
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}"), Authorize]
        public void Delete(Guid id)
        {
            this._customerService.Remove(id);
        }
    }
}
