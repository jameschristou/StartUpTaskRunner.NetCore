using System.Threading.Tasks;

namespace JcCore.StartUpTaskRunner
{
    public interface IStartUpTask
    {
        Task Run();
    }
}