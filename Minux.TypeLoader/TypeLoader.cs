using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Extensions.Logging;

namespace Minux.TypeLoader
{
    public class TypeLoader
    {
        private readonly IServiceProvider _provider;
        private readonly ILogger<TypeLoader> _logger;

        public TypeLoader(IServiceProvider provider, ILogger<TypeLoader> logger)
        {
            _provider = provider;
            _logger = logger;
        }

        public IEnumerable<Type> Load<TService>()
        {
            Type typeOfService = typeof(TService);

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (typeOfService.IsAssignableFrom(type))
                    {
                        yield return type;
                    }
                }
            }
        }

        public IEnumerable<(Type, TAttribute)> Load<TService, TAttribute>()
        where TAttribute : Attribute
        {
            Type typeOfService = typeof(TService);

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in assembly.GetTypes())
                {
                    if (typeOfService.IsAssignableFrom(type))
                    {
                        var attribute = type.GetCustomAttribute<TAttribute>();
                        if (attribute != null)
                            yield return (type, attribute);
                    }
                }
            }
        }
    }
}
