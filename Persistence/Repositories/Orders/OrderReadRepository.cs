using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories.Orders;
using Domain.Entitites;
using Persistence.Context;

namespace Persistence.Repositories.Orders
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(DataContext context) : base(context)
        {
        }
    }
}