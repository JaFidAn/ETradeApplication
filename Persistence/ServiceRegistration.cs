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
                            .GetConnectionString("SqlConnection")), ServiceLifetime.Singleton);

            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();

            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
