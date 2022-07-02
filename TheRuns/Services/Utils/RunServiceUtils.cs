using TheRuns.Models;
using TheRuns.Models.DB;
using TheRuns.Models.Requests;

namespace TheRuns.Services.Utils
{
    static class RunServiceUtils
    {
        public static RunDto CreateRunDto(CreateRunRequest run)
        {
            var pace = CalculatePace(run.DistanceInMiles, run.Duration);

            var request = new RunDto()
            {
                UserId = run.UserId,
                DateOfRun = run.DateOfRun,
                DistanceInMiles = run.DistanceInMiles,
                RunDuration = TimeSpan.Parse(run.Duration),
                AveragePacePerMile = pace,
                Notes = run.Notes,
            };

            return request;
        }

        public static RunDto UpdateRunDto(UpdateRunRequest run)
        {
            var pace = CalculatePace(run.DistanceInMiles, run.Duration);

            var request = new RunDto()
            {
                Id = run.StringId,
                UserId = run.UserId,
                DateOfRun = run.DateOfRun,
                DistanceInMiles = run.DistanceInMiles,
                RunDuration = TimeSpan.Parse(run.Duration),
                AveragePacePerMile = pace,
                Notes = run.Notes,
            };

            return request;
        }

        public static RunDetails MapToRunDetails(RunDto run)
        {
            var runDetails = new RunDetails()
            {
                Id = run.Id,
                UserId = run.UserId,
                DateOfRun = run.DateOfRun,
                DistanceInMiles = run.DistanceInMiles,
                RunDuration = run.RunDuration,
                AveragePacePerMile = run.AveragePacePerMile,
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

        private static TimeSpan CalculatePace(double distance, string duration)
        {
            TimeSpan time = TimeSpan.Parse(duration);
            double pace = time.TotalSeconds / distance;
            TimeSpan convertedPace = TimeSpan.FromSeconds(pace);
            return convertedPace;
        }
    }
}
