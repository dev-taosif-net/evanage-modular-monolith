using Evanage.Modules.Events.Domain.Events;
using Evanage.Modules.Events.Infrastructure.Database;

namespace Evanage.Modules.Events.Infrastructure.Events;

public sealed class EventRepository(EventsDbContext context)
    : IEventRepository
{
    public void Insert(Event @event)
    {
        context.Events.Add(@event);
    }
}
