using System;
using ProiectPSSC.Domain.Models;

namespace ProiectPSSC.Domain.Repositories.Interfaces
{
    public interface IEmployerRepository
    {
        Employer LoadEmployer(string name, string pass);
        void AddEmployer(Employer employer);
    }
}
