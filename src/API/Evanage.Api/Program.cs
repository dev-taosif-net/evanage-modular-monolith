using Evanage.Modules.Events.Infrastructure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

builder.Services.AddEventsModule(builder.Configuration);

EventsModule.MapEndpoints(app);
app.MapGet("/", () => "Hello World!");

await app.RunAsync();
