using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T> FindAsync(Expression<Func<T,bool>> filter);
        IQueryable<T> GetAll();
        IQueryable<T> FindAll(Expression<Func<T,bool>> filter);
        void Insert(T entity);
        Task Delete(Expression<Func<T,bool>> filter);
        void DeleteRange(Expression<Func<T, bool>> filter);
    }
}
