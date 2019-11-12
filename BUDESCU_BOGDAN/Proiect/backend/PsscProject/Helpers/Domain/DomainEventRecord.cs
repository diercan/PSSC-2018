using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Helpers.Domain
{
    public class DomainEventRecord
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public List<KeyValuePair<string, string>> Args { get; set; }
        public DateTime Created { get; set; }
    }
}
