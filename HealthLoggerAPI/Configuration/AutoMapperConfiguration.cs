using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HealthLoggerAPI.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.
                AddAutoMapper(
                   Assembly.GetAssembly(typeof(Business.ConcreteImplementation.Mappers.BaseMapper))
                );
        }

    }
}
