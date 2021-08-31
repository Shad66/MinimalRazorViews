# MinimalRazorViews

Enhance the new .Net 6 minimal API by letting you return Razor Views.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorViews();

var app = builder.Build();

app.MapGet("/", () => Razor.View("TestView", new { Place = "Cape Town"}, app));

await app.RunAsync();
```