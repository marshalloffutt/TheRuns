using TheRuns.Models;

namespace TheRuns.Services
{
    public class RunService : IRunService
    {

        public RunService()
        {
            //connect to db
        }

        public List<RunDetails> GetUserRuns(Guid userId)
        {
            throw new NotImplementedException();
        }

        public RunDetails GetRunDetails(int id)
        {
            throw new NotImplementedException();
        }

        public RunDetails CreateRun(RunDetails run)
        {
            throw new NotImplementedException();
        }

        public RunDetails UpdateRun(RunDetails run)
        {
            throw new NotImplementedException();
        }

        public void DeleteRun(int id)
        {
            throw new NotImplementedException();
        }
    }
}
