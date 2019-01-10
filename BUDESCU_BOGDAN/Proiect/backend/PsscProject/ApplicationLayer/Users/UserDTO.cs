using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Users
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
