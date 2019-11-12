using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.History
{
    public interface IHistoryService
    {
        HistoryDTO GetHistory();
        void AddEvent<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : DomainEvent;
    }
}
