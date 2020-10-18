using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace JcCore.StartUpTaskRunner.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static async Task RunStartUpTasks(this IServiceProvider serviceProvider)
        {
            var tasks = serviceProvider.GetService<IEnumerable<IStartUpTask>>();

            foreach (var startUpTask in tasks)
            {
                await startUpTask.Run();
            }
        }
    }
}