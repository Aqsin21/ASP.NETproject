using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Common
{
    public interface IAsyncRepository<T>
         where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetAsync(Expression<Func<T, bool>>? predicate = null, CancellationToken cancellationToken = default);
        Task AddAsync(T entry, CancellationToken cancellationToken = default);
        void Edit(T entry);
        void Remove(T entry);
        Task<int> SaveAsync(CancellationToken cancellationToken = default);

    }
}
