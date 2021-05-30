using Business.ConcreteImplementation;
using Business.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLoggerAPI.Configuration
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterDependencies(
            this IServiceCollection services)
        {
            services.AddScoped<ICommonService, CommonService>();
            return services;
        }
    }
}
