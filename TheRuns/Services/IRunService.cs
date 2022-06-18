using TheRuns.Models;

namespace TheRuns.Services
{
    public class RunService : IRunService
    {

        public RunService()
        {
            //connect to db
        }

        public RunDetails CreateRun (RunDetails run)
        {
            //add to db
            return new RunDetails();
        }
    }
}
