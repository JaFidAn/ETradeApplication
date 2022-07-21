using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Concrete;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(
            this IServiceCollection services
        )
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
