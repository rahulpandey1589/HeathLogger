using Data;
using Data.Configuration;
using Data.Repositories.Concrete;
using Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HealthLoggerAPI.Configuration
{
    public static class DbContextInit
    {
        public static IServiceCollection RegisterDbContext(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<HealthLoggerDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<Func<HealthLoggerDbContext>>((provider) => () => provider.GetService<HealthLoggerDbContext>());
            services.AddScoped<DbFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection RegisterRepositories(
           this IServiceCollection services)
        {
            services.AddScoped<IRelationShipRepository, RelationShipRepository>();
            return services;
        }

    }
}
