using Evanage.Modules.Events.Application.Events.Commands;
using Evanage.Modules.Events.Application.Events.Queries;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evanage.Modules.Events.Presentation.EndPoints;

public static class EventEndpoints
{
    public static void MapEndpoints(IEndpointRouteBuilder app)
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
        app.MapGet("events/{id}", async (Guid id, ISender sender) =>
            {
                EventResponse? @event = await sender.Send(new GetEventQuery(id));

                return @event is null ? Results.NotFound() : Results.Ok(@event);
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
