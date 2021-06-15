using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Models
{
    public static class DepedencyInjection
    {

        public static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
