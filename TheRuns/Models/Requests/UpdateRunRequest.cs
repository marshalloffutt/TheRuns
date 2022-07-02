using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TheRuns.Models.Requests
{
    public class UpdateRunRequest
    {
        public string StringId { get; set; }
        public string UserId { get; set; }
        public DateTime DateOfRun { get; set; }
        public double DistanceInMiles { get; set; }
        public string Duration { get; set; } //"dd:hh:mm:ss"
        public string Notes { get; set; }
    }
}
