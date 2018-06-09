using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Minux.TypeLoader
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTypeLoader(this IServiceCollection services)
        {
            services.AddSingleton<TypeLoader>();
            return services;
        }
    }
}
