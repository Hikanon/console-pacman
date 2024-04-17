using study.Config;
using study.Entity;

namespace study.Service
{
    internal class EventService
    {

        internal ConfigurationReader ConfigurationReader { get; }


        public void ExecuteEvents()
        {
            GetEvents().ForEach(e => e.DoEvent());
        }

        private List<Event> GetEvents()
        {
            List<Event> events = new List<Event>();
            ConsoleKeyInfo key = Console.ReadKey();
            events.Add(ParseCommandToEvent(key));
            return events;

        }

        private Event ParseCommandToEvent(ConsoleKeyInfo key)
        {
            throw new NotImplementedException();
        }
    }
}