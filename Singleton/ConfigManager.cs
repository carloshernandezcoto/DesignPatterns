namespace PatternsApp.Singleton
{
    public class ConfigManager
    {
        private IDictionary<string, object> settings = new Dictionary<string, object>();
        private static ConfigManager instance = new ConfigManager();

        public static ConfigManager Instance { get => instance; }

        private ConfigManager()
        { }

        public void Set(string key, object value)
        {
            settings.Add(key, value);
        }
        public object Get(string key)
        {
            return settings[key];
        }
    }
}