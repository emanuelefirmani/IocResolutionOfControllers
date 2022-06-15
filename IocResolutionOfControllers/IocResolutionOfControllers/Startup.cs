namespace IocResolutionOfControllers;

internal class Startup
{
    internal static WebApplicationBuilder CreateBuilder() =>
        WebApplication.CreateBuilder(new WebApplicationOptions
        {
            ApplicationName = typeof(Program).Assembly.FullName
        });

    internal static void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc().AddControllersAsServices();
        IocModule.AddDependencies(services);
    }
}