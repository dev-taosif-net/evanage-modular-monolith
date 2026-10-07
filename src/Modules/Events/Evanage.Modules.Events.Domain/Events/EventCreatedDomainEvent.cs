using Evanage.Modules.Events.Domain.Abstractions;

namespace Evanage.Modules.Events.Domain.Events;

public sealed class EventCreatedDomainEvent(Guid eventId) : DomainEvent
{
    public Guid EventId { get; init; } = eventId;
}
