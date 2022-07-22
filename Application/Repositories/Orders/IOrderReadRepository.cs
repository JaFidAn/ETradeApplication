using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entitites;

namespace Application.Repositories.Orders
{
    public interface IOrderReadRepository : IReadRepository<Order>
    {
        
    }
}