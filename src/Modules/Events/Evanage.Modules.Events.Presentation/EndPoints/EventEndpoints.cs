using Evanage.Modules.Events.Presentation.EndPoints.Events;

namespace Evanage.Modules.Events.Presentation.EndPoints;

public static class EventEndpoints
{
    public static void MapEndpoints(IEndpointRouteBuilder app)
    {
        CreateEvent.MapEndpoint(app);
        GetEvent.MapEndpoint(app);
    }
}
