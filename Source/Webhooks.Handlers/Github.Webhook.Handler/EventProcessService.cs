using System.Collections.Generic;
using System.Linq;
using Github.Webhook.Handler.Strategy;

namespace Github.Webhook.Handler
{
    public class EventProcessService
    {
        public void Process(ICollection<string> actions, object data)
        {
            var action = actions.FirstOrDefault();
            if (action == default(string)) return;

            var eventProcessStrategy = GetEventProcessStrategy(action);
            eventProcessStrategy.Process(data);
        }

        private static IEventProcessStrategy GetEventProcessStrategy(string action)
        {
            var eventProcessStrategy = default(IEventProcessStrategy);

            switch (action)
            {
                case "create":
                    eventProcessStrategy = new CreateEventStrategy();
                    break;
            }
            return eventProcessStrategy;
        }
    }
}
