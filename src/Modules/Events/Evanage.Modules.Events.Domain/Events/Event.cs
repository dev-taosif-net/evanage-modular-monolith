namespace Evanage.Modules.Events.Domain.Events;

public sealed class Event
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public required string Location { get; set; }

    public DateTime StartsAtUtc { get; set; }

    public DateTime? EndsAtUtc { get; set; }

    public EventStatus Status { get; set; }
}
