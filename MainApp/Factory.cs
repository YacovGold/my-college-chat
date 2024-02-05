using MainApp.Dal;

namespace MainApp
{
    public class Factory
    {
        private static readonly Lazy<Factory> instance = new Lazy<Factory>(() => new Factory());
        public static Factory Instance { get { return instance.Value; } }


        public ConfigData ConfigData { get; private set; }
        public MongoDal MongoDal { get; private set; }
        public UsersDal UsersDal { get; private set; }
        public MessagesDal MessagesDal { get; private set; }
        public State State { get; private set; }


        private Factory()
        {
            ConfigData = new ConfigData();
            MongoDal = new MongoDal(ConfigData);
            UsersDal = new UsersDal(MongoDal, ConfigData);
            MessagesDal = new MessagesDal(MongoDal, ConfigData);
            State = new State();
        }
    }
}
