using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FeedbackApi.Models
{
    public class Feedback
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
