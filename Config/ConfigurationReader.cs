using Microsoft.Extensions.Configuration;
using study.Entity;

namespace study.Config
{
    internal class ConfigurationReader
    {

        internal Dictionary<string, Configuration> configs;

        public ConfigurationReader()
        {
            this.configs = new Dictionary<string, Configuration>();
        }

        public void AddConfiguration(string filePath)
        {
            throw new NotImplementedException();
        }

        public Configuration GetConfiguration(string configName)
        {
            return configs[configName];
        }

    }
}
