using Github.Webhook.Handler.Extensions;
using Github.Webhook.Handler.ViewModel.Events;
using QualityChecker.Common.CrossCutting;

namespace Github.Webhook.Handler.Strategy
{
    public class CreateEventStrategy : IEventProcessStrategy
    {

        public void Process(object data)
        {
            if (data == null) return;

            var createEvent = ObjectConverter.GetDataOrDefault<CreateEvent>(data);

            if (createEvent == default(CreateEvent)) return;

            var createEventPayload = createEvent.ConvertToCreateEventPayLoad();

            // Call Quality Checker API
        }
    }
}
