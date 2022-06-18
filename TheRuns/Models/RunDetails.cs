namespace TheRuns.Models
{
    public class RunDetails
    {
        public int Id { get; set; }
        public RunType? RunType { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateOfRun { get; set; }
        public decimal DistanceInMiles { get; set; }
        public TimeSpan RunDuration { get; set; }
        public decimal MinutesPerMile { get; set; }
        public string? Notes { get; set; }
    }
}
