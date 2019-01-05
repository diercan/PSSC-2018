using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.History
{
    public class EventDTO
    {
        public string Type { get; set; }
        public Dictionary<string, string> Args { get; set; }
        public DateTime Created { get; set; }

        public string Id { get; set; }
    }
}
