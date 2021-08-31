# MinimalRazorViews

Render Razor views from the new .net 6 minimal API.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorViews();

var app = builder.Build();

app.MapGet("/", () => Razor.View("TestView", new { Place = "Cape Town"}, app));

await app.RunAsync();
```

By default, Razor will look for Views in /Views

TestView example

```csharp
@model dynamic

hello from @Model.Place
```