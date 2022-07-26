using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Abstraction;
using Application.Repositories.Customers;
using Application.Repositories.Orders;
using Application.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Concrete;
using Persistence.Context;
using Persistence.Repositories.Customers;
using Persistence.Repositories.Orders;
using Persistence.Repositories.Products;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(
            this IServiceCollection services,
            IConfiguration config
        )
        {
            services
                .AddDbContext<DataContext>(options =>
                    options
                        .UseSqlServer(config
                            .GetConnectionString("SqlConnection")));

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
