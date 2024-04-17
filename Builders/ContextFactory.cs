using study.Entity;

namespace study.Builders
{
    internal static class ContextFactory
    {
        private static Context? context;

        public static Context GetContext()
        {
            if (context == null)
            {
                context = (Context)Factory.GetObject(typeof(Context));
            }
            return context;
        }
    }
}