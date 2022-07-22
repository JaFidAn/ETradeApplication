using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories.Products;
using Domain.Entitites;
using Persistence.Context;

namespace Persistence.Repositories.Products
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(DataContext context) : base(context)
        {
        }
    }
}