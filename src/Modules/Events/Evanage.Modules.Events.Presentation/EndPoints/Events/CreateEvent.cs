using Evanage.Modules.Events.Application.Events.Commands;

namespace Evanage.Modules.Events.Presentation.EndPoints.Events;

internal static class CreateEvent
{
    public static void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("events", async (Request request, ISender sender) =>
            {
                var command = new CreateEventCommand(
                    request.Title,
                    request.Description,
                    request.Location,
                    request.StartsAtUtc,
                    request.EndsAtUtc);

                Guid eventId = await sender.Send(command);

                return Results.Ok(eventId);
            })
            .WithTags(Tags.Events);
    }

    internal sealed class Request
    {
        public required string Title { get; set; }

        public required string Description { get; set; }

        public required string Location { get; set; }

        public DateTime StartsAtUtc { get; set; }

        public DateTime? EndsAtUtc { get; set; }
    }
}
