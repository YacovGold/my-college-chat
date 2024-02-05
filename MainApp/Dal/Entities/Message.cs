using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MainApp.Dal.Entities
{
    public enum MessageType { Text, Image }

    public class Message
    {
        [BsonId]
        public ObjectId MessageId { get; set; }
        public ObjectId ChatId { get; set; }

        public ObjectId UserId { get; set; }

        [BsonRepresentation(BsonType.String)]
        public MessageType Type { get; set; }

        public string Text { get; set; }
        public string ImageLocation { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
