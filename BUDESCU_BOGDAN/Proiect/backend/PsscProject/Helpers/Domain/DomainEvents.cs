using Newtonsoft.Json;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Helpers.Domain
{
    public class DomainEvents 
    {
        private static List<Delegate> actions;
        private static List<DomainEventRecord> domainEvents = new List<DomainEventRecord>();

        //Registers a callback for the given domain event, used for testing only
        public static void Register<T>(Action<T> callback) where T : DomainEvent
        {
            if (actions == null)
                actions = new List<Delegate>();

            actions.Add(callback);
        }

        //Clears callbacks passed to Register on the current thread
        public static void ClearCallbacks()
        {
            actions = null;
        }

        //Raises the given domain event
        public static void Raise<T>(T domainEvent) where T : DomainEvent
        {
            Console.WriteLine(JsonConvert.SerializeObject(domainEvent.Args));

            domainEvents.Add(
              new DomainEventRecord()
              {
                  Created = domainEvent.Created,
                  Type = domainEvent.Type,
                  Args = domainEvent.Args.Select(kv => new KeyValuePair<string, string>(kv.Key, kv.Value.ToString())).ToList(),
                  Id = Guid.NewGuid()
              });
            Console.WriteLine(JsonConvert.SerializeObject(domainEvents));
           
        }

        public static List<DomainEventRecord> GetEvents()
        {
            return domainEvents;
        }
    }
}
