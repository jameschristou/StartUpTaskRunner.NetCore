using JcCore.StartUpTaskRunner;
using System.Threading.Tasks;

namespace JcCore.StartUpTaskRunnerTestApp
{
    public class TestStartUpTask : IStartUpTask
    {
        public async Task Run()
        {
            System.Console.WriteLine("Running TestStartUpTask");
        }
    }
}