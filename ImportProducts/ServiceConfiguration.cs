using ImportProducts.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ImportProducts
{
    class ServiceConfiguration
    {
        internal static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<ILoggerService, LoggerService>();
            services.AddTransient<Func<string, IImportProductService>>(serviceProvider => serviceName =>
            {
                return serviceName switch
                {
                    "YAML" => serviceProvider.GetService<YAMLImportProductService>(),
                    "JSON" => serviceProvider.GetService<JSONImportProductService>(),
                    _ => null,
                };
            });
            return services;
        }
    }
}
