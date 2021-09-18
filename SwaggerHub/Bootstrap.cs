using Microsoft.Extensions.DependencyInjection;
using SwaggerHub.Data.Interfaces;
using SwaggerHub.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerHub
{
    public class Bootstrap
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IDataRepository, DataRepository>();
        }
    }
}
