using TheRuns.Models;

namespace TheRuns.Services
{
    public interface IRunService
    {
        RunDetails CreateRun(RunDetails run);
    }
}
