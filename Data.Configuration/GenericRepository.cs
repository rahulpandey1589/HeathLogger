using Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Data.Configuration
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbFactory _dbFactory;
        private DbSet<T> _dbSet;

        protected DbSet<T> DbSet
        {
            get => _dbSet ?? (_dbSet = _dbFactory.DbContext.Set<T>());
        }

        public GenericRepository(DbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void Add(T entity)
        {
            if (typeof(IAuditEntity).IsAssignableFrom(typeof(T)))
            {
                ((IAuditEntity)entity).CreatedDate = DateTime.UtcNow;

            }
            DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            if (typeof(IDeleteEntity).IsAssignableFrom(typeof(T)))
            {
                ((IDeleteEntity)entity).IsDeleted = true;
                DbSet.Update(entity);
            }
            else
                DbSet.Remove(entity);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression);
        }

        public void Update(T entity)
        {
            if (typeof(IAuditEntity).IsAssignableFrom(typeof(T)))
            {
                ((IAuditEntity)entity).UpdatedDate = DateTime.UtcNow;
            }
            DbSet.Update(entity);
        }
    }
}
