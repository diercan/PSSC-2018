using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.Repository.Interfaces;

namespace PsscProject.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ICustomerService _customerService;

        public ValuesController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET api/values
        [HttpGet]
        public List<CustomerDTO> Get()
        {
            CustomerDTO customerDto = new CustomerDTO()
            {
                FirstName = "Bianca",
                LastName = "Bianca",
                Email = "bianca@gmail.com"
            };
            this._customerService.Add(customerDto);
            var b = this._customerService.Add(customerDto);
            // CustomerDTO _customerDto = new CustomerDTO()
            // {
            //     Id = b.Id,
            //     FirstName = "BudescuUpdate",
            //     LastName = "BogdanUpdate",
            //     Email = "bogdanbudeaaaaaascu96@gmail.com"
            // };
            // this._customerService.Remove(b.Id);
            // this._customerService.GetAll();
            return this._customerService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
