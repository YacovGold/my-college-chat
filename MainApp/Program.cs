using MongoDB.Driver;
using MainApp.Dal.Entities;
using MainApp.forms;

namespace MainApp
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }

        public static void RunUser(string nick)
        {
            var q = Factory.Instance.MongoDal.mongoDb.GetCollection<User>(Factory.Instance.ConfigData.UserColName).AsQueryable();
            var myUser = q.First(v => v.Nick == nick);
            Factory.Instance.State.CurrentUser = myUser;

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}