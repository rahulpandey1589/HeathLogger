using System;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Configuration
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> Get(Expression<Func<T, bool>> expression);
    }
}
