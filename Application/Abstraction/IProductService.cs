using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entitites;

namespace Application.Abstraction
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
