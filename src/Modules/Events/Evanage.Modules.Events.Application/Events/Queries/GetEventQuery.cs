using MediatR;

namespace Evanage.Modules.Events.Application.Events.Queries;

public sealed record GetEventQuery(Guid EventId) : IRequest<EventResponse?>;

public sealed record EventResponse(
    Guid Id,
    string Title,
    string Description,
    string Location,
    DateTime StartsAtUtc,
    DateTime? EndsAtUtc);

