using Microsoft.AspNetCore.Mvc;
using TheRuns.Models;
using TheRuns.Services;

namespace TheRuns.Controllers
{
    [Route("api/[controller]")]
    public class RunController : ControllerBase
    {
        private readonly IRunService _runService;

        public RunController(IRunService runService)
        {
            _runService = runService;
        }

        [HttpGet]
        public List<RunDetails> GetUserRuns(Guid userId)
        {
            return _runService.GetUserRuns(userId);
        }

        [HttpGet]
        public RunDetails GetRunDetails(int id)
        {
            return _runService.GetRunDetails(id);
        }

        [HttpPost]
        public RunDetails CreateRun(RunDetails run)
        {
            return _runService.CreateRun(run);
        }

        [HttpPut]
        public RunDetails UpdateRun(RunDetails run)
        {
            return _runService.UpdateRun(run);
        }

        [HttpDelete]
        public void DeleteRun(int id)
        {
            _runService.DeleteRun(id);
        }
    }
}
