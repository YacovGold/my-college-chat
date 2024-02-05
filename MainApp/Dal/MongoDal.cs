using MongoDB.Driver;

namespace MainApp.Dal
{
    public class MongoDal
    {
        public IMongoDatabase mongoDb;

        public MongoDal(ConfigData configData)
        {
            var mc = new MongoClient(configData.MainConnectionString);
            mongoDb = mc.GetDatabase(new MongoUrl(configData.MainConnectionString).DatabaseName);
        }
    }
}
