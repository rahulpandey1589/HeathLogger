using Business.ConcreteImplementation.Common;
using Business.Configuration.Common;
using Microsoft.Extensions.DependencyInjection;

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
