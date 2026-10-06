using MediatR;

namespace Evanage.Modules.Events.Application.Events.Commands;

public sealed record CreateEventCommand(
string Title,
string Description,
string Location,
DateTime StartsAtUtc,
DateTime? EndsAtUtc) : IRequest<Guid>;
