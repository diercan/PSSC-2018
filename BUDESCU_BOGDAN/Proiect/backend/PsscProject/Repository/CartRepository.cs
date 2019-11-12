using PsscProject.ApplicationLayer.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository.Interfaces
{
    public class CartRepository : RepositoryBase<CartDTO>, ICartRepository
    {
        public CartRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
