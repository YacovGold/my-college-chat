using System.Configuration;

namespace MainApp.Dal
{
    public class ConfigData
    {
        public string MainConnectionString
        {
            get => ConfigurationManager.ConnectionStrings["MAIN_DB"].ConnectionString;
        }

        public string UserColName
        {
            get => ConfigurationManager.AppSettings["USERS_COL_NAME"].ToString();
        }

        public string MessageColName
        {
            get => ConfigurationManager.AppSettings["MESSAGE_COL_NAME"].ToString();
        }

        public string ChatColName
        {
            get => ConfigurationManager.AppSettings["CHAT_COL_NAME"].ToString();
        }

        public string BaseDataDir
        {
            get => ConfigurationManager.AppSettings["BASE_DATA_DIR"].ToString();
        }
    }
}


