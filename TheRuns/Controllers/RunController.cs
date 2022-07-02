using Microsoft.AspNetCore.Mvc;
using TheRuns.Models;
using TheRuns.Models.Requests;
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

        [HttpGet("{userId}")]
        public List<RunDetails> GetUserRuns(string userId)
        {
            return _runService.GetUserRuns(userId);
        }

        [HttpPost]
        public string CreateRun(CreateRunRequest run)
        {
            return _runService.CreateRun(run);
        }

        [HttpPut]
        public void UpdateRun(UpdateRunRequest run)
        {
            _runService.UpdateRun(run);
        }

        [HttpDelete("{id}")]
        public void DeleteRun(string id)
        {
            _runService.DeleteRun(id);
        }
    }
}
