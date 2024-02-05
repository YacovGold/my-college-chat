using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MainApp.Dal.Entities
{
    public enum ChatType { User, Group }

    public class Chat
    {
        [BsonId]
        public ObjectId ChatId { get; set; }

        [BsonRepresentation(BsonType.String)]
        public ChatType ChatType { get; set; }

        public ObjectId[] Users { get; set; }

        public string PreviewText { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string GroupTitle { get; set; }
    }
}
