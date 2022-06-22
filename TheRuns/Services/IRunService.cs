using TheRuns.Models;

namespace TheRuns.Services
{
    public interface IRunService
    {
        List<RunDetails> GetUserRuns(Guid userId);
        string CreateRun(RunDetails run);
        void UpdateRun(RunDetails run);
        void DeleteRun(int id);
    }
}
