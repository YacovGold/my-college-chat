using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MainApp.Dal.Entities;
using Message = MainApp.Dal.Entities.Message;

namespace MainApp.Dal
{
    public class MessagesDal
    {
        IMongoCollection<Message> mdal;
        IMongoCollection<Chat> cdal;

        public MessagesDal(MongoDal mongoDal, ConfigData configData)
        {
            mdal = mongoDal.mongoDb.GetCollection<Message>(configData.MessageColName);
            cdal = mongoDal.mongoDb.GetCollection<Chat>(configData.ChatColName);
        }

        public IList<Chat> ListChats(ObjectId[] usersIds)
        {
            var q = cdal.AsQueryable().Where(v => usersIds.All(x => v.Users.Contains(x)));
            var result = q.OrderByDescending(v => v.UpdatedAt).ToList();
            return result;
        }

        public void UpdateChat(Chat chat)
        {
            cdal.ReplaceOne(v => v.ChatId == chat.ChatId, chat);
        }

        public ObjectId CreateChat(Chat chat)
        {
            cdal.InsertOne(chat);
            return chat.ChatId;
        }

        public IList<Message> ListMessages(ObjectId chatId)
        {
            var q = mdal.AsQueryable().Where(v => v.ChatId == chatId);
            var result = q.ToList();
            return result;
        }

        public void CreateMessage(Message m)
        {
            mdal.InsertOne(m);

            var maxLen = 10;
            var prevMessage = m.Text;

            if (prevMessage.Length > maxLen)
            {
                prevMessage = m.Text.Substring(0, maxLen) + "...";
            }

            var filter = Builders<Chat>.Filter.Eq(v => v.ChatId, m.ChatId);
            var update = Builders<Chat>.Update.Set(v => v.PreviewText, prevMessage);
            var update2 = Builders<Chat>.Update.Set(v => v.UpdatedAt, DateTime.UtcNow);

            cdal.UpdateOne(filter, update);
            cdal.UpdateOne(filter, update2);
        }
    }
}
