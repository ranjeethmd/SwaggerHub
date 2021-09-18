using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SwaggerHub.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static void Bootstrap<T>(this IServiceCollection services)
        {
            var type = typeof(T);
            MethodInfo registeration = type.GetMethod("Register");
            registeration.Invoke(null, new object[] { services });
        }
    }
}
