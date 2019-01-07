using PsscProject.ApplicationLayer.Carts;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository
{
    public class CartProductRepository : RepositoryBase<CartDTO>, ICartProductRepository
    {
        public CartProductRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
