public static class Razor
{
    public static async Task<IResult> View<TModel>(string view, TModel model, WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var service = scope.ServiceProvider.GetRequiredService<ViewRenderService>();

        return await service.PageAsync(view, model);
    }
}