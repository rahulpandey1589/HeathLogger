using FluentValidation;
using HealthLoggerAPI.Models.Request;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLoggerAPI.Configuration
{
    public static class RegisterValidator
    {

        public static void RegisterFluentValidation(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IValidator<TestMasterViewModel>, TestMasterViewModelValidator>();
        }

    }
}
