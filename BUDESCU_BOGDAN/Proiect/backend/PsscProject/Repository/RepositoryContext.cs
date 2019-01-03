using Microsoft.EntityFrameworkCore;
using PsscProject.Models;
using PsscProject.Models.Customers;
using PsscProject.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Product> Products { get; set; }
    }
}
