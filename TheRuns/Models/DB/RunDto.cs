using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TheRuns.Models.DB
{
    public class RunDto
    {
        [BsonId]
        [BsonElement(elementName: "_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public RunType RunType { get; set; }
        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid UserId { get; set; }
        public DateTime DateOfRun { get; set; }
        public decimal DistanceInMiles { get; set; }
        public TimeSpan RunDuration { get; set; }
        public decimal MinutesPerMile { get; set; }
        public string Notes { get; set; }
    }
}
