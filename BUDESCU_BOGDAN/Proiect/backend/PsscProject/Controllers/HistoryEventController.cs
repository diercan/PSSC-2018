using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PsscProject.ApplicationLayer.History;

namespace PsscProject.Controllers
{
    [Produces("application/json")]
    [Route("api/HistoryEvent")]
    public class HistoryEventController : Controller
    {
        private IHistoryService _historyService;
        private IMapper _mapper;
        public HistoryEventController(IHistoryService historyService, IMapper mapper)
        {
            Console.WriteLine("history controller");
            _mapper = mapper;
            _historyService = historyService;
        }
        // GET: api/HistoryEvent
        [HttpGet]
        public HistoryDTO GetHistory()
        {
            return this._historyService.GetHistory();
        }

        //// GET: api/HistoryEvent/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        //// POST: api/HistoryEvent
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}
        
        //// PUT: api/HistoryEvent/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        
        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
