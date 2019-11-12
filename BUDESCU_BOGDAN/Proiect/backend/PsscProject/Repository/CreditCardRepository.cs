using PsscProject.ApplicationLayer.Customers;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository
{
    public class CreditCardRepository : RepositoryBase<CreditCardDTO>, ICreditCardRepository
    {
        public CreditCardRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
