using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data.Configuration
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);

        T Update(int id, T entity);

        List<T> GetAll();

        T GetById(int id);

        T Get(Expression<Func<T, bool>> where);

        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
    }
}
