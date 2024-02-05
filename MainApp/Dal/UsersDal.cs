using MongoDB.Bson;
using MongoDB.Driver;
using MainApp.Dal.Entities;

namespace MainApp.Dal
{
    public class UsersDal
    {
        IMongoCollection<User> dal;

        public UsersDal(MongoDal mongoDal, ConfigData configData)
        {
            dal = mongoDal.mongoDb.GetCollection<User>(configData.UserColName);
        }

        public User Login(string nick)
        {
            var existingUser = dal.AsQueryable().FirstOrDefault(v => v.Nick == nick);
            return existingUser;
        }

        public User Register(string nick)
        {
            var existingUser = dal.AsQueryable().FirstOrDefault(v => v.Nick == nick);
            if (existingUser != null)
            {
                // TODO: We should do this in atomic way, maybe another time :)
                // I guess with a unique index...
                throw new Exception("User with the provided nick already exists");
            }

            var result = new User { Nick = nick };
            dal.InsertOne(result);
            return result;
        }

        public User UpdateUser(User user)
        {
            var targetDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            targetDir = Path.Combine(targetDir, Factory.Instance.ConfigData.BaseDataDir, "ProfileImages");

            if (user.ProfileImageLocation != null && !user.ProfileImageLocation.StartsWith(targetDir))
            {
                var ext = Path.GetExtension(user.ProfileImageLocation);

                Directory.CreateDirectory(targetDir);

                var targetPath = Path.Combine(targetDir, $"{Path.GetRandomFileName()}{ext}");
                File.Copy(user.ProfileImageLocation, targetPath);
                user.ProfileImageLocation = targetPath;
            }
            dal.ReplaceOne(v => v.UserId == user.UserId, user);
            return user;
        }

        public IList<User> ListUsers(string filter)
        {
            var query = dal.AsQueryable() as IQueryable<User>;

            if (filter != null)
            {
                query = query.Where(v => v.Nick.Contains(filter));
            }

            var users = query.ToList();
            return users;
        }

        public User GetUser(ObjectId UserId)
        {
            var result = dal.AsQueryable().First(v => v.UserId == UserId);
            return result;
        }
    }
}
