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

        [HttpGet("{userId}")]
        public List<RunDetails> GetUserRuns(Guid userId)
        {
            return _runService.GetUserRuns(userId);
        }

        [HttpPost]
        public string CreateRun([FromBody] RunDetails run)
        {
            return _runService.CreateRun(run);
        }

        [HttpPut("{id}")]
        public void UpdateRun([FromBody] RunDetails run)
        {
            _runService.UpdateRun(run);
        }

        [HttpDelete("{id}")]
        public void DeleteRun(int id)
        {
            _runService.DeleteRun(id);
        }
    }
}
