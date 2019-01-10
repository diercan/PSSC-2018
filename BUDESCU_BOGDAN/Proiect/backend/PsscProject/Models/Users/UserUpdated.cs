using PsscProject.ApplicationLayer.Users;
using PsscProject.Helpers.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Users
{
    public class UserUpdated: DomainEvent
    {
        UserDTO userDTO { get; set; }
        public UserUpdated(UserDTO userDto)
        {
            this.Args.Add("Username", userDto.Username);
            this.Args.Add("Role", userDto.Role);
        }
    }
}
