var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/hello", () =>
{
    return f"hello from dotnet";
})

app.Run();