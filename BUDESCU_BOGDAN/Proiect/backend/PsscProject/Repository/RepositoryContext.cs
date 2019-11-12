using Microsoft.EntityFrameworkCore;
using PsscProject.ApplicationLayer.Carts;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.Products;
using PsscProject.Models;
using PsscProject.Models.Customers;
using PsscProject.Models.Products;
using PsscProject.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository
{
    public class RepositoryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CustomerDTO> Customers { get; set; }
        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<CreditCardDTO> CreditCards { get; set; }
        public DbSet<CartDTO> Carts { get; set; }

        public RepositoryContext(DbContextOptions options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
