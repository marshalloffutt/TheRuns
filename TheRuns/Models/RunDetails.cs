﻿namespace TheRuns.Models
{
    public class RunDetails
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime DateOfRun { get; set; }
        public double DistanceInMiles { get; set; }
        public TimeSpan RunDuration { get; set; }
        public TimeSpan AveragePacePerMile { get; set; }
        public string Notes { get; set; }
    }
}
