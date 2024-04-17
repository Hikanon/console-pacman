namespace study.Entity
{
    internal class Configuration
    {

        internal Dictionary<string, string> parameters;

        public Configuration()
        {
            this.parameters = new Dictionary<string, string>();
        }

        public string ReadParameter(string name)
        {
            return parameters[name];
        }

    }
}
