using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entitites.Common;

namespace Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);

        Task<bool> AddRangeAsync(List<T> model);

        bool Remove(T model);

        Task<bool> RemoveAsync(string id);

        bool Update(T model);
        Task<int> SaveAsync();
    }
}
