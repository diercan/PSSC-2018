using PsscProject.ApplicationLayer.Users;
using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Users
{
    public class UserLogged : DomainEvent
    {
        UserDTO userDTO { get; set; }
        public UserLogged(UserDTO userDto)
        {
            this.Args.Add("Username", userDto.Username);
            this.Args.Add("Role", userDto.Role);
        }
    }
}
