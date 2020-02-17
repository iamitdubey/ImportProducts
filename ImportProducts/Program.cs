using ImportProducts.Service;
using ImportProducts.Service.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ImportProducts
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = ServiceConfiguration.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            var loggerService = serviceProvider.GetService<ILoggerService>();
            ImportProductLog scheduledReportLog = new ImportProductLog { LogStatus = 1 };

            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
            logger.LogInformation("Starting Product Import");

            if (args.Length != 0)
            {
                var importProductServices = serviceProvider.GetService<Func<string, IImportProductService>>();
                // based on the type of args provided we are going to invoke the relevant service i.e. Json, yaml etc
                var importProductService = importProductServices(args[0]);
                if (importProductService != null)
                {
                    await importProductService.ProcessImport();
                }
                else
                {
                    scheduledReportLog.ErrorMessage = $"Arguement name not supported {args[0]}";
                    await loggerService.InsertError(scheduledReportLog);
                }
            }
            else
            {
                scheduledReportLog.ErrorMessage = "No argument passed while invoking";
                await loggerService.InsertError(scheduledReportLog);
            }
        }
    }
}
