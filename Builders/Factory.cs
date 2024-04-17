using System.Reflection;

namespace study.Builders
{
    internal static class Factory
    {

        public static object GetObject(Type serviceType)
        {
            if (serviceType == null)
            {
                throw new ArgumentNullException(nameof(serviceType));
            }

            object service = Activator.CreateInstance(serviceType);
            foreach (var field in serviceType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if(field.GetValue(service) == null)
                {
                    field.SetValue(service, GetObject(field.FieldType));
                }
            }

            return service;
        }
    }
}