using JcCore.StartUpTaskRunner;
using System.Threading.Tasks;

namespace JcCore.StartUpTaskRunnerTestApp
{
    public class AnotherExampleStartUpTask : IStartUpTask
    {
        public async Task Run()
        {
            System.Console.WriteLine("Running AnotherExampleStartUpTask");
        }
    }
}