using Model.Context;
using Model.Interface;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Model.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> _dbSet;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task Delete(Expression<Func<T, bool>> filter)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(filter);
            if (entity == null) return;
            Delete(entity);
        }

        public void DeleteRange(Expression<Func<T, bool>> filter)
        {
            var entities = _dbSet.Where(filter);
            foreach (var entity in entities)
                Delete(entity);
        }
        private void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached) _dbSet.Attach(entity);
            _dbSet.Remove(entity);
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.FirstOrDefaultAsync(filter);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }
    }
}
