using ProiectPSSC.Domain.Services.Entities;

namespace ProiectPSSC.Domain.Models
{
    public class Employer : EmployerEntity
    {
        public Employer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
