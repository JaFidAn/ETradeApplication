using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories.Customers;
using Domain.Entitites;
using Persistence.Context;

namespace Persistence.Repositories.Customers
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(DataContext context) : base(context)
        {
        }
    }
}