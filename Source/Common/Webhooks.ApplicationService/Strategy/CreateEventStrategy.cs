using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualityChecker.Common.CrossCutting;
using QualityChecker.Common.Payload.Events;
using Webhooks.ViewModels.Github.Extensions;

namespace Webhooks.ApplicationService.Strategy
{
    public class CreateEventStrategy : IEventProcessStrategy
    {

        public void Process(object data)
        {
            if (data == null) return;

            var createEvent = ObjectConverter.GetDataOrDefault<ViewModels.Github.Events.CreateEvent>(data);

            if (createEvent == default(ViewModels.Github.Events.CreateEvent)) return;

            var createEventPayload = createEvent.ConvertToCreateEventPayLoad();

            // Call Quality Checker API
        }
    }
}
