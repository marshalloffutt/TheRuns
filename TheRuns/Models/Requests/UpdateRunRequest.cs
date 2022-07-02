namespace TheRuns.Models.Requests
{
    public class UpdateRunRequest
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateOfRun { get; set; }
        public double DistanceInMiles { get; set; }
        public string Duration { get; set; } //"dd:hh:mm:ss"
        public string Notes { get; set; }
    }
}
