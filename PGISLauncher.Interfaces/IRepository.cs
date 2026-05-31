using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PGISLauncher.Interfaces
{
    public interface IRepository<TKey, T> where T : class
    {
        Task AddAsync(T entity);
        Task<T> GetByIdAsync(TKey id);
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        Task SaveChangesAsync();
    }
}
