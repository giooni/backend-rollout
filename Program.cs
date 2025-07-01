var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var podName = Environment.GetEnvironmentVariable("HOSTNAME") ?? "unknown-host";
app.MapGet("/api/hello", () => $"Hello, KubeRocketCI from {podName}");

app.Run();
