using study.Config;

namespace study.Service
{
    internal class ConfigurationService
    {
        internal ConfigurationReader configurationReader;
        public ConfigurationReader ConfigurationReader { get => configurationReader; set => configurationReader = value; }
    }
}
