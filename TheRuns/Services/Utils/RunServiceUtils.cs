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

        public static RunDetails MapToRunDetails(RunDto run)
        {
            var runDetails = new RunDetails()
            {
                RunType = run.RunType,
                UserId = run.UserId,
                DateOfRun = run.DateOfRun,
                DistanceInMiles = run.DistanceInMiles,
                RunDuration = run.RunDuration,
                MinutesPerMile = run.MinutesPerMile,
                Notes = run.Notes,
            };

            return runDetails;
        }

        public static List<RunDetails> MapToRunDetailsList(List<RunDto> dbRuns)
        {
            var runDetailsList = new List<RunDetails>();

            foreach (var run in dbRuns)
            {
                var runDetails = MapToRunDetails(run);
                runDetailsList.Add(runDetails);
            };

            return runDetailsList;
        }
    }
}
