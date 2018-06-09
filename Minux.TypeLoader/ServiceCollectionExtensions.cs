using System;
using System.Collections.Generic;
using System.Text;
using Minux.TypeLoader;

namespace Microsoft.Extensions.DependencyInjection
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
