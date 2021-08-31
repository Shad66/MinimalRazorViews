public static class StartupExtensions
{
    public static IServiceCollection AddRazorViews(this IServiceCollection services, string viewPath = "")
    {
        services.AddTransient<ViewRenderService>();
        services.AddRazorPages().WithRazorPagesRoot(string.IsNullOrEmpty(viewPath) ? "/Pages" : viewPath);

        return services;
    }
}