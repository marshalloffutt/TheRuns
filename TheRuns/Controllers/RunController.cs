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
    }
}
