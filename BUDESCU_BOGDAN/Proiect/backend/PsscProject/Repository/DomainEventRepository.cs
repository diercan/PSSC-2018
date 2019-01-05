using PsscProject.Helpers.Domain;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository
{
    public class DomainEventRepository : IDomainEventRepository
    {
        private List<DomainEventRecord> domainEvents = new List<DomainEventRecord>();

        public void Create<TDomainEvent>(TDomainEvent domainEvent) where TDomainEvent : DomainEvent
        {
            this.domainEvents.Add(
                new DomainEventRecord()
                {
                    Created = domainEvent.Created,
                    Type = domainEvent.Type,
                    Args = domainEvent.Args.Select(kv => new KeyValuePair<string, string>(kv.Key, kv.Value.ToString())).ToList(),
                    Id = Guid.NewGuid()
                });
            foreach (var e in domainEvents)
            {
                Console.WriteLine(e.Created);
            }
        }

        public IEnumerable<DomainEventRecord> FindAll()
        {
            Console.WriteLine(domainEvents);

            return this.domainEvents;
        }
    }
}
