using TheRuns.Models;
using TheRuns.Models.Requests;

namespace TheRuns.Services
{
    public interface IRunService
    {
        List<RunDetails> GetUserRuns(Guid userId);
        string CreateRun(CreateRunRequest run);
        void UpdateRun(UpdateRunRequest run);
        void DeleteRun(int id);
    }
}
