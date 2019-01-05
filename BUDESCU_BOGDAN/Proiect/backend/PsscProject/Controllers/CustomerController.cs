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
using PsscProject.Models.Customers;

namespace PsscProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;
        private IHistoryService _historyService;
        private IMapper _mapper;

        public CustomerController(ICustomerService customerService, IHistoryService historyService, IMapper mapper)
        {
            _customerService = customerService;
            _historyService = historyService;
            _mapper = mapper;
        }

        // GET: api/Customer
        [HttpGet, Authorize(Roles = "Manager")]
        public IEnumerable<CustomerDTO> Get()
        {
            return this._customerService.GetAll();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get"), Authorize(Roles = "Manager")]
        public CustomerDTO Get(Guid id)
        {
            return this._customerService.Get(id);
        }
        
        // POST: api/Customer
        [HttpPost, Authorize]
        public CustomerDTO Post([FromBody]JObject value)
        {
            CustomerDTO customerDto = new CustomerDTO()
            {
                LastName = (String)value["lastName"],
                FirstName = (String)value["firstName"],
                Email = (String)value["email"],
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
            };
            this._customerService.Update(customerDto);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}"), Authorize]
        public void Delete(Guid id)
        {
            this._customerService.Remove(id);
        }
    }
}
