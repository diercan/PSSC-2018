using Newtonsoft.Json;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Helpers.Domain
{
    public class DomainEvents 
    {
        public static List<DomainEventRecord> domainEvents = new List<DomainEventRecord>();
        public static string path = @"C:\Users\bogdan.budescu\Desktop\PSSC\PSSC-2018\BUDESCU_BOGDAN\Proiect\backend\EventsLog.json";
        
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
            if (domainEvents.Count > 0)
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(domainEvents, Formatting.Indented));
            }
            
        }

        public static List<DomainEventRecord> GetEvents()
        {
            return domainEvents;
        }
    }
}
