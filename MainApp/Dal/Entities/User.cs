using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MainApp.Dal.Entities
{
    public enum GenderType { Male, Female }

    public class User
    {
        private string nick;


        [BsonId]
        public ObjectId UserId { get; set; }

        public string Nick
        {
            get { return nick; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException($"{nameof(Nick)} is required.");
                nick = value;
            }
        }

        [BsonRepresentation(BsonType.String)]
        public GenderType Gender { get; set; } = GenderType.Male;

        public string ProfileImageLocation { get; set; }


        public User ShallowCopy() => (User)MemberwiseClone();
    }
}
