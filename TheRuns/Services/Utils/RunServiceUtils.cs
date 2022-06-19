using TheRuns.Models;
using TheRuns.Models.DB;

namespace TheRuns.Services.Utils
{
    static class RunServiceUtils
    {
        public static RunDto MapToDto(RunDetails run)
        {
            var request = new RunDto()
            {
                RunType = run.RunType,
                UserId = run.UserId,
                DateOfRun = run.DateOfRun,
                DistanceInMiles = run.DistanceInMiles,
                RunDuration = run.RunDuration,
                MinutesPerMile = run.MinutesPerMile,
                Notes = run.Notes,
            };

            return request;
        }
    }
}
