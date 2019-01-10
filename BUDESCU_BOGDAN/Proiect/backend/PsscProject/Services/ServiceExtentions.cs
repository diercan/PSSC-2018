using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using PsscProject.ApplicationLayer.Carts;
using PsscProject.ApplicationLayer.Customers;
using PsscProject.ApplicationLayer.History;
using PsscProject.ApplicationLayer.Products;
using PsscProject.ApplicationLayer.Users;
using PsscProject.Helpers.Domain;
using PsscProject.Repository;
using PsscProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PsscProject.Services
{
    public static class ServiceExtentions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["mysqlconnection:connectionString"];
            services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString));
        }

        public static void ConfigureAppServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICreditCardRepository, CreditCardRepository>();
            services.AddScoped<IDomainEventRepository, DomainEventRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IHistoryService, HistoryService>();
            services.AddScoped<ICartService, CartService>();
        }
    }
}
