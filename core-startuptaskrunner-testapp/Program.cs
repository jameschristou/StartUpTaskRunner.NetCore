using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using JcCore.StartUpTaskRunner;
using JcCore.StartUpTaskRunner.Extensions;

namespace JcCore.StartUpTaskRunnerTestApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceProvider = ConfigureServices().BuildServiceProvider();

            // run the startup tasks
            await serviceProvider.RunStartUpTasks();

            // wait for eternity :-)
            Thread.Sleep(-1);
        }

        private static IServiceCollection ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<IStartUpTask, TestStartUpTask>();

            return serviceCollection;
        }
    }
}
