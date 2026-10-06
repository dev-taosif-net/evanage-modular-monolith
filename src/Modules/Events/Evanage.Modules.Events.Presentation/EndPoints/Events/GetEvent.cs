using Evanage.Modules.Events.Application.Events.Queries;

namespace Evanage.Modules.Events.Presentation.EndPoints.Events;

internal static class GetEvent
{
    public static void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("events/{id}", async (Guid id, ISender sender) =>
            {
                EventResponse? @event = await sender.Send(new GetEventQuery(id));

                return @event is null ? Results.NotFound() : Results.Ok(@event);
            })
            .WithTags(Tags.Events);
    }
}
