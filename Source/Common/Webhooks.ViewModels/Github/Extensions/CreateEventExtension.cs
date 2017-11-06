using Webhooks.ViewModels.Github.Events;

namespace Webhooks.ViewModels.Github.Extensions
{
    public static class CreateEventExtension
    {
        public static QualityChecker.Common.Payload.Events.CreateEvent ConvertToCreateEventPayLoad(this CreateEvent createEvent)
        {
            var createEventPayload = new QualityChecker.Common.Payload.Events.CreateEvent
            {
                Reference = createEvent.Ref,
                Repository = new QualityChecker.Common.Payload.Repository
                {
                    Id = createEvent.Repository.Id,
                    Name = createEvent.Repository.Name,
                    CreatedAt = createEvent.Repository.CreatedAt,
                    UpdatedAt = createEvent.Repository.UpdatedAt,
                    PushedAt = createEvent.Repository.PushedAt,
                },
                Sender = new QualityChecker.Common.Payload.Sender
                {
                    Id = createEvent.Sender.Id,
                    Login = createEvent.Sender.Login
                }
            };

            return createEventPayload;
        }
    }
}