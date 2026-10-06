using Evanage.Api.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.ApplyMigrations();

app.MapGet("/", () => "Hello World!");

await app.RunAsync();
