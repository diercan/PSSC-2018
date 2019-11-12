using PsscProject.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.ApplicationLayer.Users
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        User Create(User user, string password);
        void Update(User user, string password = null);
    }
}
