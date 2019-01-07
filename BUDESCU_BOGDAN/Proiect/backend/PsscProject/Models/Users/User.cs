using PsscProject.Helpers.Domain;
using PsscProject.Models.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Models.Users
{
    public class User: IAggregateRoot
    {
        public Guid Id { get; set; }
        public PlainText UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public Role Role { get; set; }

        public static User Create(PlainText userName, byte[] passwordHash, byte[] passwordSalt, Role role)
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                UserName = userName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Role = role
            };
        }
    }
}
