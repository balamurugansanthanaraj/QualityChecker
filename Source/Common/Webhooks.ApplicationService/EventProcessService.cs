using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webhooks.ApplicationService.Strategy;

namespace Webhooks.ApplicationService
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
