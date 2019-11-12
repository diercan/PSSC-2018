using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository.Interfaces
{
    public interface IDomainEventRepository 
    {
        void Create<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : DomainEvent;
        IEnumerable<DomainEventRecord> FindAll();
    }
}
