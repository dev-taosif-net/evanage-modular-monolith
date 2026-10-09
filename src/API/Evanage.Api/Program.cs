using Evanage.Modules.Events.Infrastructure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddEventsModule(builder.Configuration);

WebApplication app = builder.Build();

EventsModule.MapEndpoints(app);
app.MapGet("/", () => "Hello World!");

await app.RunAsync();
