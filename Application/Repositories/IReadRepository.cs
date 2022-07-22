using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Entitites.Common;

namespace Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);

        Task<T> GetByIdAsync(string id);
    }
}
