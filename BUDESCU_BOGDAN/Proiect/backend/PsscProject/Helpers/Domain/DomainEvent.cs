using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Helpers.Domain
{
    public abstract class DomainEvent
    {
        public string Type { get { return this.GetType().Name; } }
        public DateTime Created { get; private set; }
        public Dictionary<string, Object> Args { get; private set; }
        public Guid Id { get; set; }
        public DomainEvent()
        {
            this.Created = DateTime.Now;
            this.Args = new Dictionary<string, Object>();
        }

    }
}
