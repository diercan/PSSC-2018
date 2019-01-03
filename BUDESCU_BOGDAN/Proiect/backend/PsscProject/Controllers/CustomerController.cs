using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PsscProject.ApplicationLayer.Customers;

namespace PsscProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<CustomerDTO> Get()
        {
            return this._customerService.GetAll();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public CustomerDTO Get(Guid id)
        {
            return this._customerService.Get(id);
        }
        
        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody]JObject value)
        {
            CustomerDTO customerDto = new CustomerDTO()
            {
                LastName = (String)value["lastName"],
                FirstName = (String)value["firstName"],
                Email = (String)value["email"],
            };
            this._customerService.Add(customerDto);
        }
        
        // PUT: api/Customer/5
        [HttpPut("{id}")]
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
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            Console.WriteLine(id);
            this._customerService.Remove(id);
        }
    }
}
