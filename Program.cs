var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/ping", () => "pong");

app.MapGet("getNumber", () => Random.Shared.Next(1, 5));

app.Run();
