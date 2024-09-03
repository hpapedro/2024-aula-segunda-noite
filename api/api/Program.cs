//Minimal Apis em C#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Vamos Flamengo!");

app.MapGet("/segundafuncionalidade", () => "Segundamente Vasco!");

app.Run();
