using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TheRuns.Models.DB
{
    public class UserDto
    {
        [BsonId]
        [BsonElement(elementName: "_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
