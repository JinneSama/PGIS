using PGISLauncher.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PGISLauncher.Services.Base
{
    public class BaseService<TKey, T> : IBaseService<TKey, T> where T : class
    {
        private readonly IRepository<TKey, T> _baseRepo;
        public BaseService(IRepository<TKey, T> baseRepo)
        {
            _baseRepo = baseRepo;
        }

        public virtual async Task AddAsync(T entity)
        {
            await _baseRepo.AddAsync(entity);
        }
        public virtual async Task<T> GetByIdAsync(TKey id)
        {
            return await _baseRepo.GetByIdAsync(id);
        }

        public virtual async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _baseRepo.GetByFilterAsync(filter);
        }

        public virtual IQueryable<T> GetAll() 
        {
            return _baseRepo.GetAll();
        }

        public virtual async Task SaveChangesAsync()
        {
            await _baseRepo.SaveChangesAsync();
        }

    }
}
