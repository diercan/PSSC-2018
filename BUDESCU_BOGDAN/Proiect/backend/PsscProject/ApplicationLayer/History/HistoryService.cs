using AutoMapper;
using PsscProject.Helpers.Domain;
using PsscProject.Repository;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.History
{
    public class HistoryService : IHistoryService
    {
        private IDomainEventRepository domainEventRepository;
        private readonly IMapper _mapper;
        public HistoryService(IMapper mapper, IDomainEventRepository domainEventRepository)
        {
            _mapper = mapper;
            this.domainEventRepository = domainEventRepository;
        }

        public void AddEvent<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : DomainEvent
        {
            domainEventRepository.Create(domainEvent);
        }

        public HistoryDTO GetHistory()
        {
            IEnumerable<DomainEventRecord> events = DomainEvents.GetEvents();
           
            HistoryDTO history = new HistoryDTO();
            history.Events = _mapper.Map<IEnumerable<DomainEventRecord>, List<EventDTO>>(events);

            return history;
        }
    }
}
