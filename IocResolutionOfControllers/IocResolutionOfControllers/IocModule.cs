namespace IocResolutionOfControllers;

public class IocModule
{
    public static void AddDependencies(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddTransient<ADependency>();
    }
}