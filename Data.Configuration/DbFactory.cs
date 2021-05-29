using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Configuration
{
    public class DbFactory : IDisposable
    {
        private bool _disposed;
        private Func<HealthLoggerDbContext> _instanceFunc;

        private DbContext _dbContext;
        public DbContext DbContext => _dbContext ?? (_dbContext = _instanceFunc.Invoke());

        public DbFactory(Func<HealthLoggerDbContext> dbContextFactory)
        {
            _instanceFunc = dbContextFactory;
        }

        public void Dispose()
        {
            if (!_disposed && _dbContext != null)
            {
                _disposed = true;
                _dbContext.Dispose();
            }
        }
    }
}
