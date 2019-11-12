using PsscProject.ApplicationLayer.Customers;
using PsscProject.Models;
using PsscProject.Models.Customers;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository
{
    public class CustomerRepository : RepositoryBase<CustomerDTO>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}

